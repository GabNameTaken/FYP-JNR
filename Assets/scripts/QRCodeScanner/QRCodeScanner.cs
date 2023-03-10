using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeScanner : InteractableObject
{
    private ScannerClicked scannerController;
    // Start is called before the first frame update
    void Start()
    {
        scannerController = transform.parent.GetComponent<ScannerClicked>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnClick()
    {
        scannerController.SetScannerToActive();
    }
}
