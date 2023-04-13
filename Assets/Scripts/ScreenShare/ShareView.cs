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
    private GameObject canvasGO;
    [SerializeField] private GameObject playerButton;
    [SerializeField] GameObject shareViewClosePrefab;

    public List<Player> listOfViewers = new();

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine)
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        localPlayerList = GameObject.Find("Network").GetComponent<LocalPlayerList>();
        shareScreenCanvas = GameObject.FindGameObjectWithTag("ShareScreenCanvas");
        shareViewList = shareScreenCanvas.transform.Find("SharedList").transform.Find("Viewport").transform.Find("Content").gameObject;

        canvasGO = GameObject.Find("NetworkCanvasController");
    }

    private void Update()
    {
        if (listOfViewers.Count > 0)
        {
            canvasGO.GetComponent<ShareCanvas>().Share(listOfViewers);
        }
    }

    [PunRPC]
    public void UpdateShareList(Player host)
    {
        GameObject go = Instantiate(playerButton, shareViewList.transform);
        go.GetComponentInChildren<TextMeshProUGUI>().text = host.NickName.ToUpper();
        go.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().ViewPlayerScreen(host); });
    }

    [PunRPC]
    public void CallShareScreen(Player viewer)
    {
        Debug.Log(viewer.NickName + " is viewing");
        photonView.RPC("ShareScreen", viewer, PhotonNetwork.LocalPlayer.ActorNumber);
        //canvasGO.GetComponent<ShareCanvas>().SendCanvasToOtherPlayers(canvasGO.GetComponent<Canvas>(), canvasGO.GetComponent<PhotonView>().ViewID);
        Debug.Log("calling share screen now");
    }

    [PunRPC]
    public void ShareScreen(int hostPlayerNum)
    {
        Debug.Log(hostPlayerNum);
        //Debug.Log(PhotonNetwork.PlayerList[hostPlayerNum] + " sharing to " + PhotonNetwork.PlayerList[gameObject.GetComponent<PlayerInfo>().playerNum]);
        Debug.Log(hostPlayerNum + " sharing to " + PhotonNetwork.LocalPlayer.ActorNumber);
        host = localPlayerList.FindPlayer(hostPlayerNum);
        if (host != null)
        {
            Camera hostCam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            hostCam.rect = new Rect(0.05f, 0.05f, 0.9f, 0.9f);
            hostCam.depth = 1;
            myCam.depth = -1;
            shareViewCloseButton = Instantiate(shareViewClosePrefab,shareScreenCanvas.transform);
            shareViewCloseButton.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().CloseView(PhotonNetwork.LocalPlayer); });
            Debug.Log("share success");

            foreach(GameObject child in canvasGO.GetComponent<ShareCanvas>().gameObjects)
            {
                if (child.GetComponent<Canvas>())
                {
                    child.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
                    child.GetComponent<Canvas>().worldCamera = hostCam;
                    child.GetComponent<Canvas>().sortingOrder = 1;
                }
                else if (child.transform.GetChild(0).GetComponent<Canvas>())
                {
                    for (int i = 0; i < child.transform.childCount; i++)
                    {
                        child.transform.GetChild(i).GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
                        child.transform.GetChild(i).GetComponent<Canvas>().worldCamera = hostCam;
                        child.transform.GetChild(i).GetComponent<Canvas>().sortingOrder = 1;
                    }
                }
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
            foreach (GameObject child in canvasGO.GetComponent<ShareCanvas>().gameObjects)
            {
                child.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            }
            Destroy(shareViewCloseButton);
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
