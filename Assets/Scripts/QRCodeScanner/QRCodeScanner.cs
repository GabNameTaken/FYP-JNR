using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeScanner : InteractableObject
{
    private CanvasToggle scannerController;

    void Start()
    {
        scannerController = transform.parent.GetComponent<CanvasToggle>();
    }

    public override void OnClick()
    {
        scannerController.SetCanvasToActive();
    }
}
