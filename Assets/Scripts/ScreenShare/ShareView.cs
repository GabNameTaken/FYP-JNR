using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class ShareView : MonoBehaviour
{
    private PhotonView photonView;
    [SerializeField] private Camera myCam;
    public Camera cam;
    private GameObject shareScreenCanvas;
    private GameObject shareViewList;
    private LocalPlayerList localPlayerList;
    GameObject host;
    GameObject shareViewCloseButton;
    [SerializeField] private GameObject playerButton;
    [SerializeField] GameObject shareViewClosePrefab;

    public List<Player> listOfViewers = new();
    private Dictionary<string, bool> savedActiveCanvas;
    private Dictionary<string, bool> savedActiveGameObjects;
    private Dictionary<int, string> savedInputFields;
    private Dictionary<int, string> savedTextFields;

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine)
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        localPlayerList = GameObject.Find("Network").GetComponent<LocalPlayerList>();
        shareScreenCanvas = GameObject.FindGameObjectWithTag("ShareScreenCanvas");
        shareViewList = shareScreenCanvas.transform.Find("SharedList").transform.Find("List").transform.Find("Viewport").transform.Find("Content").gameObject;
        myCam.rect = new Rect(0.027f, 0.13f, 0.94f, 0.74f);
    }

    public static Rect RectTransformToCameraViewport(RectTransform rectTransform)
    {
        float leftDownCornerX = (rectTransform.anchoredPosition.x - rectTransform.sizeDelta.x / 2);
        float leftDownCornerY = (rectTransform.anchoredPosition.y - rectTransform.sizeDelta.y / 2);

        Vector3 leftCorner = new Vector3(leftDownCornerX, leftDownCornerY, 0);
        Vector3 viewPortLeftCorner = new Vector3(leftCorner.x / Screen.width, leftCorner.y / Screen.height, 0);

        float viewportWidth = Mathf.Abs(rectTransform.sizeDelta.x / Screen.width);
        float viewportHeight = Mathf.Abs(rectTransform.sizeDelta.y / Screen.height);

        return new Rect(0.5f + viewPortLeftCorner.x, 0.5f + viewPortLeftCorner.y, viewportWidth, viewportHeight);
    }

    private void Update()
    {
        if (listOfViewers.Count > 0)
        {
            shareScreenCanvas.GetComponent<ShareCanvas>().Share(listOfViewers);
        }
    }

    [PunRPC]
    public void UpdateShareList(Player host)
    {
        GameObject go = Instantiate(playerButton, shareViewList.transform);
        go.name = host.ActorNumber.ToString();
        go.GetComponentInChildren<TextMeshProUGUI>().text = host.NickName.ToUpper();
        go.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().ViewPlayerScreen(host); });
    }

    [PunRPC]
    public void DestroyShareList(Player host)
    {
        if (shareViewList.transform.Find(host.ActorNumber.ToString()))
        {
            GameObject hostListing = shareViewList.transform.Find(host.ActorNumber.ToString()).gameObject;
            Destroy(hostListing);
        }
    }

    [PunRPC]
    public void RemoveAllViewers()
    {
        foreach (Player viewer in listOfViewers)
        {
            shareViewList.GetComponent<ShareViewList>().CloseView(viewer);
        }
    }

    [PunRPC]
    public void PreShareScreen()
    {
        savedActiveCanvas = shareScreenCanvas.GetComponent<ShareCanvas>().SaveActiveStateOfCanvases();
        savedActiveGameObjects = shareScreenCanvas.GetComponent<ShareCanvas>().SaveActiveStateOfGameObjects();
        savedInputFields = shareScreenCanvas.GetComponent<ShareCanvas>().SaveInputFields();
        savedTextFields = shareScreenCanvas.GetComponent<ShareCanvas>().SaveTextFields();
    }

    [PunRPC]
    public void CallShareScreen(Player viewer)
    {
        Debug.Log(viewer.NickName + " is viewing");
        photonView.RPC("ShareScreen", viewer, PhotonNetwork.LocalPlayer.ActorNumber, PhotonNetwork.LocalPlayer.NickName);
        Debug.Log("calling share screen now");
    }

    [PunRPC]
    public void ShareScreen(int hostPlayerNum, string hostName)
    {
        Debug.Log(hostPlayerNum);
        Debug.Log(hostPlayerNum + " sharing to " + PhotonNetwork.LocalPlayer.ActorNumber);
        host = localPlayerList.FindPlayer(hostPlayerNum);
        if (host != null)
        {
            Camera hostCam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            //RectTransform screen = (RectTransform)shareScreenCanvas.transform.Find("ShareScreen").Find("Screen").transform;
            //hostCam.rect = RectTransformToCameraViewport(screen);
            shareScreenCanvas.transform.Find("ShareScreen").Find("Name").GetChild(0).GetComponent<TMP_Text>().text = hostName;
            hostCam.rect = new Rect(0.027f, 0.13f, 0.94f, 0.74f);
            hostCam.depth = 1;
            myCam.depth = -1;

            shareViewCloseButton = shareScreenCanvas.transform.Find("SharedList").transform.Find("CloseViewButton").gameObject;
            shareViewCloseButton.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().CloseView(PhotonNetwork.LocalPlayer); });
            shareViewCloseButton.SetActive(true);
            Debug.Log("share success");

            foreach (Canvas canvas in shareScreenCanvas.GetComponent<ShareCanvas>().shareableCanvases)
            {
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = hostCam;
                canvas.sortingOrder = 1;
                canvas.planeDistance = 1;
            }

            Debug.Log("Canvas cam change success");
        }
    }

    [PunRPC]
    public void CloseViewScreen()
    {
        if (host != null)
        {
            Camera hostCam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            hostCam.rect = new Rect(0f,0f,1f,1f);
            hostCam.depth = -1;
            myCam.depth = 0;
           
            foreach (Canvas canvas in shareScreenCanvas.GetComponent<ShareCanvas>().shareableCanvases)
            {
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            }

            shareScreenCanvas.GetComponent<ShareCanvas>().SetActiveStateOfCanvases(savedActiveCanvas);
            shareScreenCanvas.GetComponent<ShareCanvas>().SetActiveStateOfGameObjects(savedActiveGameObjects);
            shareScreenCanvas.GetComponent<ShareCanvas>().SetInputFields(savedInputFields);
            shareScreenCanvas.GetComponent<ShareCanvas>().SetTextFields(savedTextFields);

            shareViewCloseButton.GetComponent<Button>().onClick.RemoveAllListeners();
            shareViewCloseButton.SetActive(false);
        }
        Debug.Log("Quit viewing");
    }

    [PunRPC]
    public void ListViewer(Player viewer)
    {
        listOfViewers.Add(viewer);
        Debug.Log(viewer.NickName + " added to the viewerList");
    }

    [PunRPC]
    public void RemoveViewer(Player viewer)
    {
        if (host != null)
        {
            if (host.GetComponent<ShareView>().listOfViewers.Contains(viewer))
            {
                host.GetComponent<ShareView>().listOfViewers.Remove(viewer);
                Debug.Log(viewer.NickName + " removed from the viewerList");
            }
            else
            {
                Debug.Log("host doesn't contain viewer");
            }
        }
        else
            Debug.Log("host is null");
    }
}
