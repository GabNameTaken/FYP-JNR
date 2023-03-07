using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionSafe : InteractableObject
{
    private ReceptionSafeClicked receptionSafeController;

    [SerializeField] GameObject pager;
    [SerializeField]
    private Canvas popupCanvas;
    private Camera playerCam;
    private Quaternion originalRot;
    private bool opened = false;
    public void GetPlayerCam(Camera cam)
    {
        playerCam = cam;
    }

    private void Start()
    {
        receptionSafeController = transform.parent.GetComponent<ReceptionSafeClicked>();
    }

    public void resetCam()
    {
        //playerCam.GetComponent<CCameraControls>().enabled = true;
        //playerCam.transform.rotation = originalRot;
        pager.gameObject.SetActive(false);
    }

    public void OpenSafe(bool yes)
    {
        opened = yes;
    }
    public override void OnClick()
    {
        if (opened == true)
        {
            pager.gameObject.SetActive(true);
        }
        //originalRot = playerCam.transform.rotation;
        //playerCam.transform.rotation = Quaternion.identity;
        //playerCam.GetComponent<CCameraControls>().enabled = false;
        receptionSafeController.SetSafeToActive();
    }
}
