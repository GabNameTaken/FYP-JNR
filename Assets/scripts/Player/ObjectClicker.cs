using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    private Ray raycast;
    private RaycastHit raycastHit;
    private Camera cam;

    GameObject objectOnHover;
    Color originalColor;
    float highlightFactor = 0.5f;

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

    private void HighlightInteractable()
    {
        Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
        originalColor = renderer.material.GetColor("_Color");
        Color newColor = new Color(255f,255f, originalColor.b, originalColor.a);
        renderer.material.SetColor("_Color", newColor);
    }

    private void RestoreInteractable()
    {
        if (objectOnHover != null)
        {
            Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
            renderer.material.SetColor("_Color", originalColor);
            objectOnHover = null;
        }
    }

    private void Update()
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            InteractableObject interactableObject = raycastHit.transform.gameObject.GetComponent<InteractableObject>();
            CItem item = raycastHit.transform.gameObject.GetComponent<CItem>();
            if (objectOnHover == null)
            {
                if (interactableObject)
                {
                    objectOnHover = raycastHit.transform.gameObject;
                    Debug.Log(objectOnHover.transform.name);
                    HighlightInteractable();
                }
                else if (item)
                {
                    if (raycastHit.transform.name == "Cheese Puzzle")
                    {
                        objectOnHover = raycastHit.transform.GetChild(1).transform.GetChild(0).gameObject;
                    }
                    else
                        objectOnHover = raycastHit.transform.GetChild(0).gameObject;
                    Debug.Log(objectOnHover.transform.name);
                    HighlightInteractable();
                }
            }
            else if (raycastHit.transform != objectOnHover.transform)
            {
                RestoreInteractable();
                if (interactableObject)
                {
                    objectOnHover = raycastHit.transform.gameObject;
                }
                else if (item)
                {
                    if (raycastHit.transform.name == "Cheese Puzzle")
                    {
                        objectOnHover = raycastHit.transform.GetChild(1).transform.GetChild(0).gameObject;
                    }
                    else
                        objectOnHover = raycastHit.transform.GetChild(0).gameObject;
                }
                HighlightInteractable();
            }
        }
        else
            RestoreInteractable();
    }
}