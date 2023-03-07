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
        target.transform.rotation = Quaternion.LookRotation(target.GetComponent<CItem>().getV3Normal(), target.GetComponent<CItem>().getV3Up());
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
            target.transform.rotation = Quaternion.LookRotation(target.GetComponent<CItem>().getV3Normal(), target.GetComponent<CItem>().getV3Up());
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
        target.transform.position = inspectCamera.transform.forward.normalized * distFromCam;
    }
}
