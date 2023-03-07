using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionPC : InteractableObject
{
    private ReceptionPClicked receptionPCController;

    private void Start()
    {
        receptionPCController = transform.parent.GetComponent<ReceptionPClicked>();
    }

    public override void OnClick()
    {
        receptionPCController.SetPCScreenToActive();
    }
}
