using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCanvas : InteractableObject
{
    CanvasToggle pcController;

    private void Start()
    {
        pcController = transform.parent.GetComponent<CanvasToggle>();
    }

    public override void OnClick()
    {
        pcController.SetCanvasToActive();
    }
}
