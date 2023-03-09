using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    private Ray raycast;
    private RaycastHit raycastHit;
    private Camera cam;

    private void Awake()
    {
        cam = this.gameObject.GetComponent<Camera>();
    }

    public void Click()
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            InteractableObject interactableObject = raycastHit.transform.gameObject.GetComponent<InteractableObject>();
            if (interactableObject)
            {
                raycastHit.transform.gameObject.GetComponent<InteractableObject>().OnClick();
            }
        }
    }

    public CItem ClickOnCItem()
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            return raycastHit.transform.gameObject.GetComponent<CItem>();
        }
        return null;
    }

    public PopupItems ClickOnPopupItems()
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            return raycastHit.transform.gameObject.GetComponent<PopupItems>();
        }
        return null;
    }
}