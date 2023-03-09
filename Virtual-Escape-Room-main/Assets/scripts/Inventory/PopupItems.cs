using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupItems : InteractableObject
{
    [SerializeField] private GameObject popupBG, popupItems, roomItems;
    [SerializeField]
    private Canvas popupCanvas;
    //private Camera playerCam;
    private Quaternion originalRot;

    public void GetPlayerCam(Camera cam)
    {
        popupCanvas.worldCamera = cam;
        //playerCam = cam;
    }

    public void ClosePopup()
    {
       //playerCam.GetComponent<CCameraControls>().enabled = true;
       //playerCam.transform.rotation = originalRot;
        popupBG.SetActive(false);
        popupItems.SetActive(false);
        roomItems.SetActive(true);
    }

    public override void OnClick()
    {
        //originalRot = playerCam.transform.rotation;
        //playerCam.transform.rotation = Quaternion.identity;
        //playerCam.GetComponent<CCameraControls>().enabled = false;
        popupBG.SetActive(true);
        popupItems.SetActive(true);
        roomItems.SetActive(false);
    }
}
