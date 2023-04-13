using Photon.Pun;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ObjectInspector : MonoBehaviour
{
    PhotonView photonView;
    Camera inspectCamera;

    Vector3 prevPos; //previous position of mouse click
    Vector3 currentPos; //current position of mouse click

    GameObject target; //object to rotate

    bool isInspecting3DObject = false; //boolean to check if player is viewing the object
    const int minZoomDist = 2;
    const int maxZoomDist = 5;

    float dragSpeed = 5.0f;

    float distFromCam;
    public bool IsViewing { get => isInspecting3DObject; }

    private void Awake()
    {
        inspectCamera = GameObject.Find("InspectCamera").GetComponent<Camera>();
    }

    private void Start()
    {
        target = null;
        distFromCam = maxZoomDist;

        photonView = GetComponent<PhotonView>();

        if (photonView.IsMine)
        {
            foreach (IObjectInspectorHandler handler in FindObjectsOfType<MonoBehaviour>().OfType<IObjectInspectorHandler>())
            {
                handler.SetInspectorReference(this);
            }
        }
    }

    private void Update()
    {
        if (isInspecting3DObject)
        {
            //TODO: Should be doing this in a player camera controller
            if (target.GetComponent<CItem>().getbIsRotatable())
            {
                //click to get the previous mouse position
                if (Input.GetMouseButtonDown(0))
                {
                    prevPos = inspectCamera.ScreenToViewportPoint(Input.mousePosition);
                }

                //drag the mouse to rotate the object
                if (Input.GetMouseButton(0))
                {
                    currentPos = prevPos - inspectCamera.ScreenToViewportPoint(Input.mousePosition);
                    target.transform.Rotate(Vector3.right, -currentPos.y * 180);
                    target.transform.Rotate(Vector3.up, currentPos.x * 180f, Space.World);
                    prevPos = inspectCamera.ScreenToViewportPoint(Input.mousePosition);
                }
            }

            if (Input.mouseScrollDelta.y != 0)
            {
                Zoom3DCamera(-Input.mouseScrollDelta.y);
            }

            if (Input.GetMouseButtonDown(1))    // right mouse click
            {
                prevPos = Input.mousePosition;
                //currentPos = prevPos;
            }

            if (Input.GetMouseButton(1))    // right mouse click drag to move inspect camera
            {
                Vector3 pos = inspectCamera.ScreenToViewportPoint(Input.mousePosition - prevPos);
                prevPos = Input.mousePosition;
                Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed,0);
            
                target.transform.Translate(move, Space.World);

                //  constraint the space where the object can move
                if (target.GetComponent<CItem>().constraintToAnchor)
                {
                    if (target.transform.position.x > target.GetComponent<CItem>().anchorX)
                    {
                        target.transform.position = new Vector3(target.GetComponent<CItem>().anchorX, target.transform.position.y, target.transform.position.z);
                    }
                    else if (target.transform.position.x < -target.GetComponent<CItem>().anchorX)
                    {
                        target.transform.position = new Vector3(-target.GetComponent<CItem>().anchorX, target.transform.position.y, target.transform.position.z);
                    }
                    if (target.transform.position.y > target.GetComponent<CItem>().anchorY)
                    {
                        target.transform.position = new Vector3(target.transform.position.x, target.GetComponent<CItem>().anchorY, target.transform.position.z);
                    }
                    else if (target.transform.position.y < -target.GetComponent<CItem>().anchorY)
                    {
                        target.transform.position = new Vector3(target.transform.position.x, -target.GetComponent<CItem>().anchorY, target.transform.position.z);
                    }
                }
            }

            if (Input.GetMouseButton(2)) // middle mouse click
            {
                Reset3DInspectCamera();
            }
        }
    }

    public void Reset3DInspectCamera()
    {
        distFromCam = maxZoomDist;
        target.transform.position = inspectCamera.transform.forward.normalized * distFromCam;
        target.transform.rotation = Quaternion.Euler(target.GetComponent<CItem>().inspectRotation);
    }

    public void SetTarget(GameObject target)
    {
        this.target = target;
    }

    public void Inspect3DItem()
    {
        if (target != null && target.name != "PreviewObject")
        {
            isInspecting3DObject = true;
            target.SetActive(true);

            distFromCam = maxZoomDist;
            target.transform.position = inspectCamera.transform.forward.normalized * distFromCam;
            target.transform.rotation = Quaternion.Euler(target.GetComponent<CItem>().inspectRotation);
        }
    }

    public void StopInspecting3DItem()
    {
        if (target)
        {
            isInspecting3DObject = false;
            target.SetActive(false);
            target = null;
        }
    }

    public void ZoomIn3DCamera()
    {
        Zoom3DCamera(-distFromCam);
    }
    public void ZoomOut3DCamera()
    {
        Zoom3DCamera(maxZoomDist);
    }

    public void Zoom3DCamera(float zoomValue)
    {
        distFromCam += zoomValue;
        distFromCam = Mathf.Clamp(distFromCam, minZoomDist, maxZoomDist);
        Vector3 zoom = inspectCamera.transform.forward.normalized * distFromCam;
        target.transform.position = new Vector3(target.transform.position.x,target.transform.position.y, zoom.z);
    }
}
