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
    float highlightFactor = 0.3f;
    public Material highlightMaterial;
    public Color highlightColor;

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
                RestoreInteractable();
                raycastHit.transform.gameObject.GetComponent<InteractableObject>().OnClick();
            }
        }
    }

    public CItem ClickOnCItem()
    {
        raycast = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit))
        {
            RestoreItem();
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
        if (objectOnHover.transform.Find("HighlightBox"))
            objectOnHover.transform.Find("HighlightBox").gameObject.SetActive(true);
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
            if (objectOnHover.transform.Find("HighlightBox"))
            {
                objectOnHover.transform.Find("HighlightBox").gameObject.SetActive(false);
            }
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
                objectOnHover = raycastHit.transform.gameObject;
                if (interactableObject) //check for interactable object/item
                {
                    Debug.Log(objectOnHover.transform.name);
                    HighlightInteractable();
                }
                else if (item)
                {
                    if (!item.getbIsPickedUp())
                    {
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
                    HighlightInteractable();
                }
                else if (item)
                {
                    RestoreItem();
                    if (!item.getbIsPickedUp())
                    {
                        objectOnHover = raycastHit.transform.gameObject;
                        HighlightItems();
                    }
                }
            }
        }
        else
        {
            if (interactableObject)
                RestoreInteractable();
            if (item)
                RestoreItem();
        }
    }
}