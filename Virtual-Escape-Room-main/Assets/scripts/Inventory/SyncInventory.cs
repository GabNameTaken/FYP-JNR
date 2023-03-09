using UnityEngine;
using Photon.Pun;

public class SyncInventory : MonoBehaviour
{
    private PhotonView photonView;
    private GameObject itemHolder, previewObject;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
        itemHolder = GameObject.FindWithTag("ItemHolder");
        previewObject = GameObject.FindWithTag("PreviewObject");
    }

    public void CallPickupItem(string itemName)
    {
        photonView.RPC("PickupItem", RpcTarget.All, itemName);
    }

    [PunRPC]
    public void PickupItem(string itemName)
    {
        foreach (Transform room in itemHolder.GetComponentInChildren<Transform>())
        {
            if (room.gameObject.activeSelf)
            {
                Transform item = FindPickedUpItemFromRoom(itemName, room);

                if (item)
                {
                    CInventoryItemButtons.instance.onAddInventoryCItem(item.gameObject.GetComponent<CItem>());
                    item.gameObject.GetComponent<CItem>().setbIsPickedUp(true);
                    item.gameObject.SetActive(false);
                    item.SetParent(previewObject.transform, false);
                }
            }
        }
    }

    private Transform FindPickedUpItemFromRoom(string itemName, Transform room)
    {
        if (room)
        {
            foreach (Transform itemTransform in room.GetComponentInChildren<Transform>())
            {
                if (itemTransform.gameObject.GetComponent<CItem>() != null && itemTransform.gameObject.GetComponent<CItem>().getstrItemName() == itemName)
                {
                    return itemTransform;
                }
            }
        }

        return null;
    }
}
