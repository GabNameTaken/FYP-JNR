using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    private Ray raycast;
    private RaycastHit raycastHit;
    private Camera cam;

    InteractableObject interactableObject;
    CItem item;

    GameObject objectOnHover;
    Color originalColor;
    Material originalMaterial;
    float highlightFactor = 0.5f;
    public Material highlightMaterial;

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

    private void HighlightItems()
    {
        Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
        originalColor = renderer.material.GetColor("_Color");
        Color newColor = new Color(255f,255f, originalColor.b, originalColor.a);
        renderer.material.SetColor("_Color", newColor);
    }

    private void HighlightInteractable()
    {
        Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
        originalMaterial = renderer.material;
        renderer.material = highlightMaterial;
    }

    private void RestoreInteractable()
    {
        if (objectOnHover != null)
        {
            Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
            renderer.material = originalMaterial;
            objectOnHover = null;
        }
    }

    private void RestoreItem()
    {
        if (objectOnHover != null)
        {
            Renderer renderer = objectOnHover.GetComponent(typeof(Renderer)) as Renderer;
            renderer.material.SetColor("_Color", originalColor);
            objectOnHover = null;
        }
    }

    private void Update()   //object highlighting
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            interactableObject = raycastHit.transform.gameObject.GetComponent<InteractableObject>();
            item = raycastHit.transform.gameObject.GetComponent<CItem>();
            if (objectOnHover == null)
            {
                if (interactableObject) //check for interactable object/item
                {
                    objectOnHover = raycastHit.transform.gameObject;
                    Debug.Log(objectOnHover.transform.name);
                    HighlightInteractable();
                }
                else if (item)
                {
                    if (!item.getbIsPickedUp())
                    {
                        if (raycastHit.transform.name == "Cheese Puzzle")
                        {
                            objectOnHover = raycastHit.transform.GetChild(1).transform.GetChild(0).gameObject;
                        }
                        else
                            objectOnHover = raycastHit.transform.GetChild(0).gameObject;
                        Debug.Log(objectOnHover.transform.name);
                        HighlightItems();
                    }
                }
            }
            else if (objectOnHover != interactableObject && interactableObject)
            {
                RestoreInteractable();
                objectOnHover = interactableObject.gameObject;
                HighlightInteractable();
            }
            else if (raycastHit.transform != objectOnHover.transform)   //in the event of player swooping their mouse
            {
                if (interactableObject)
                {
                    RestoreInteractable();
                    objectOnHover = raycastHit.transform.gameObject;
                }
                else if (item)
                {
                    RestoreItem();
                    if (!item.getbIsPickedUp())
                    {
                        if (raycastHit.transform.name == "Cheese Puzzle")
                        {
                            objectOnHover = raycastHit.transform.GetChild(1).transform.GetChild(0).gameObject;
                        }
                        else
                            objectOnHover = raycastHit.transform.GetChild(0).gameObject;
                        HighlightItems();
                    }
                }
            }
        }
        else
        {
            if (interactableObject)
                RestoreInteractable();
            else if (item)
                RestoreItem();
        }
    }
}