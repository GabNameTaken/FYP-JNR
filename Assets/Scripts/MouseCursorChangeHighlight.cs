using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorChangeHighlight : MonoBehaviour
{
    private Ray raycast;
    private RaycastHit raycastHit;
    private Camera cam;

    private bool isHover;

    public Texture2D cursorHover;
    
    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
        cam = this.gameObject.GetComponent<Camera>();

        isHover = false;
    }

    //private void Update()
    //{
    //    raycast = cam.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(raycast, out raycastHit) && !isHover)
    //    {
    //        //InteractableObject interactableObject = raycastHit.transform.gameObject.GetComponent<InteractableObject>();
    //        //GameObject GO_interactableObject = raycastHit.transform.gameObject;
            
    //        // Change to cursorHover
    //        Cursor.SetCursor(cursorHover, Vector2.zero, CursorMode.ForceSoftware);
    //        isHover = true;
    //    }

    //    else if (!Physics.Raycast(raycast, out raycastHit) && isHover)
    //    {
    //        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    //        isHover = false;
    //    }
    //}
}
