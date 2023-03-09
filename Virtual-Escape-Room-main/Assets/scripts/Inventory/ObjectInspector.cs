using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ObjectInspector : MonoBehaviour
{
    [SerializeField] Camera playerCam;

    Vector3 originalPos; //original position of the camera

    Vector3 prevPos; //previous position of mouse click
    Vector3 currentPos; //current position of mouse click

    GameObject target; //object to rotate

    public CItem cItem;

    bool isInspecting3DObject = false; //boolean to check if player is viewing the object
    int distFromCam;
    int minZoomDist = 2;
    int maxZoomDist = 5;

    private PhotonView photonView;
    public bool IsViewing { get => isInspecting3DObject; }

    private void Start()
    {
        target = null;
        distFromCam = maxZoomDist;

        photonView = GetComponent<PhotonView>();

        if (photonView.IsMine)
        {
            //TODO: Find a better way to reference this in the UI Handler
            FindObjectOfType<InventoryPanelPopup>().SetInspectorToControl(this);
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
                    prevPos = playerCam.ScreenToViewportPoint(Input.mousePosition);
                }

                //drag the mouse to rotate the object
                if (Input.GetMouseButton(0))
                {
                    currentPos = prevPos - playerCam.ScreenToViewportPoint(Input.mousePosition);
                    target.transform.Rotate(Vector3.right, -currentPos.y * 180);
                    target.transform.Rotate(Vector3.up, currentPos.x * 180f, Space.World);
                    prevPos = playerCam.ScreenToViewportPoint(Input.mousePosition);
                }
            }
        }
    }

    // Reset the rotation of the object
    public void Reset3DInspectCamera()
    {
        distFromCam = maxZoomDist;
        target.transform.position = playerCam.transform.forward.normalized * distFromCam;
        target.transform.rotation = Quaternion.LookRotation(target.GetComponent<CItem>().getV3Normal(), target.GetComponent<CItem>().getV3Up());
    }

    // View the object
    public void Inspect3DItem()
    {
        target = GameObject.Find("PreviewObject").transform.Find("" + ItemButton.selectedItem).gameObject;
        if (target != null && target.name != "PreviewObject")
        {
            isInspecting3DObject = true;
            target.SetActive(true);

            originalPos = playerCam.transform.position;
            distFromCam = maxZoomDist;
            target.transform.position = playerCam.transform.forward.normalized * distFromCam;
            target.transform.rotation = Quaternion.LookRotation(target.GetComponent<CItem>().getV3Normal(), target.GetComponent<CItem>().getV3Up());
        }
    }

    // Stop viewing the object
    public void StopInspecting3DItem()
    {
        playerCam.transform.position = originalPos;
        isInspecting3DObject = false;
        target.transform.rotation = Quaternion.identity;
        target.SetActive(false);
        target = null;
    }

    public void ZoomIn3DCamera()
    {
        distFromCam = minZoomDist;
        target.transform.position = playerCam.transform.forward.normalized * distFromCam;
    }
    public void ZoomOut3DCamera()
    {
        distFromCam = maxZoomDist;
        target.transform.position = playerCam.transform.forward.normalized * distFromCam;
    }

    public void ViewDescription()
    {
        GameObject itemDescriptionPopup = GameObject.Find("Canvas").transform.Find("ItemDescPopUp").gameObject;
        itemDescriptionPopup.SetActive(true);
        TextMeshProUGUI itemDescription = itemDescriptionPopup.transform.Find("DescriptionText").gameObject.GetComponent<TextMeshProUGUI>();
        GameObject target = GameObject.Find("PreviewObject").transform.Find("" + ItemButton.selectedItem).gameObject;
        itemDescription.text = "";
        itemDescription.text = "Description : \n" + target.GetComponent<CItem>().getItemDescription(); 
    }
}
