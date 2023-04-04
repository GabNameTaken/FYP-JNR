using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionSafe : InteractableObject
{
    CanvasToggle safeCanvas;
    [SerializeField] GameObject safeItems;
    private bool opened = false;

    private void Start()
    {
        safeCanvas = transform.parent.GetComponent<CanvasToggle>();
    }

    public void Close()
    {
        safeItems.SetActive(false);
        safeCanvas.Close();
    }

    public void OpenSafe(bool yes)
    {
        opened = yes;
    }

    public override void OnClick()
    {
        if (opened == true)
        {
            safeItems.SetActive(true);
        }
        safeCanvas.SetCanvasToActive();
    }
}
