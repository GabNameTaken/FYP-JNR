using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftPanel : InteractableObject
{
    [SerializeField] CanvasToggle canvasToggle;
    public override void OnClick()
    {
        if (canvasToggle)
            canvasToggle.SetCanvasToActive();
    }
}
