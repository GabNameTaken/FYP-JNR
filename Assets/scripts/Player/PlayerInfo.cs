using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.EventSystems;

public class PlayerInfo : MonoBehaviourPun, IPunObservable
{
    [SerializeField]
    private Camera cam;
    private ObjectClicker objectClicker;
    private SyncInventory syncInventory;

    // Update Refs
    private CItem GOClickedCItem;
    private PopupItems GOClickedPopupItems;

    int PFPIndex = 0;
    int MAX_PFPsprites = 6;

    public int CurrentSprite { get { return PFPIndex; } }

    private void Awake()
    {
        objectClicker = gameObject.GetComponentInChildren<ObjectClicker>();
        syncInventory = GetComponent<SyncInventory>();

        if (photonView.IsMine)
        {
            PFPIndex = Random.Range(0, MAX_PFPsprites);
            if (cam != null)
            {
                cam.depth = 1;
                cam.gameObject.AddComponent(typeof(AudioListener));
            }
            GameObject canvas = GameObject.Find("Canvas");
            canvas.GetComponent<Canvas>().worldCamera = cam;
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonUp(0) && objectClicker && !EventSystem.current.IsPointerOverGameObject())
        {
            objectClicker.Click();
            GOClickedCItem = objectClicker.ClickOnCItem();
            if (GOClickedCItem)
            {
                syncInventory.CallPickupItem(GOClickedCItem.GetComponent<CItem>().getstrItemName());
            }
            GOClickedPopupItems = objectClicker.ClickOnPopupItems();
            if (GOClickedPopupItems)
            {
                GOClickedPopupItems.GetComponent<PopupItems>().GetPlayerCam(cam);
            }
        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) 
    { 
        if (stream.IsWriting)
        {
            //Owner
            stream.SendNext(PFPIndex);
        }
        else
        {
            //Remote
            PFPIndex = (int)stream.ReceiveNext();
        }
    }
}
