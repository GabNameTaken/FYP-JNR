using UnityEngine;
using Photon.Pun;

public class SyncInventory : MonoBehaviour
{
    private PhotonView photonView;
    private GameObject itemHolder, previewObject;

    private const int INPSECT_LAYER = 6;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
        itemHolder = GameObject.FindWithTag("ItemHolder");
        previewObject = GameObject.FindWithTag("PreviewObject");
    }

    public void CallPickupItem(string itemName)
    {
        photonView.RPC("PickupItem", RpcTarget.AllBufferedViaServer, itemName);
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
                    PhotonView itemPV = item.gameObject.GetComponent<PhotonView>();
                    itemPV.RPC("AddToInventory", PhotonNetwork.LocalPlayer);
                    //item.gameObject.GetComponent<CItem>().AddToInventory();
                    item.gameObject.GetComponent<CItem>().setbIsPickedUp(true);
                    item.SetParent(previewObject.transform, false);
                    item.gameObject.GetComponent<CItem>().getPreviewGameObject().layer = INPSECT_LAYER;

                    QueuedNotification.NotificationInfo notificationInfo = new();
                    notificationInfo.title = "Item Received: ";
                    notificationInfo.message = item.GetComponent<CItem>().getGameObjectName();
                    notificationInfo.imageSprite = item.GetComponent<CItem>().getpreviewSprite();
                    notificationInfo.durationSeconds = 2;
                    QueuedNotification.instance.QueueNotification(notificationInfo);
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
