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
    public Dictionary<string, bool> savedActiveScenes;
    public Dictionary<string, bool> savedActiveItems;
    public Dictionary<string, bool> savedActiveCanvas;

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine)
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        localPlayerList = GameObject.Find("Network").GetComponent<LocalPlayerList>();
        shareScreenCanvas = GameObject.FindGameObjectWithTag("ShareScreenCanvas");
        shareViewList = shareScreenCanvas.transform.Find("SharedList").transform.Find("List").transform.Find("Viewport").transform.Find("Content").gameObject;
    }

    private void Update()
    {
        if (listOfViewers.Count > 0)
        {
            shareScreenCanvas.GetComponent<ShareCanvas>().Share(listOfViewers);
            shareScreenCanvas.GetComponent<ShareScene>().Share(listOfViewers);
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
        //savedActiveScenes = shareScreenCanvas.GetComponent<ShareScene>().SaveActiveScenes("scenes");
        //savedActiveItems = shareScreenCanvas.GetComponent<ShareScene>().SaveActiveScenes("items");
    }

    [PunRPC]
    public void CallShareScreen(Player viewer)
    {
        Debug.Log(viewer.NickName + " is viewing");
        photonView.RPC("ShareScreen", viewer, PhotonNetwork.LocalPlayer.ActorNumber);
        Debug.Log("calling share screen now");
    }

    [PunRPC]
    public void ShareScreen(int hostPlayerNum)
    {
        Debug.Log(hostPlayerNum);
        Debug.Log(hostPlayerNum + " sharing to " + PhotonNetwork.LocalPlayer.ActorNumber);
        host = localPlayerList.FindPlayer(hostPlayerNum);
        if (host != null)
        {
            Camera hostCam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            hostCam.rect = new Rect(0.05f, 0.05f, 0.9f, 0.9f);
            hostCam.depth = 1;
            myCam.depth = -1;
            //shareViewCloseButton = Instantiate(shareViewClosePrefab,shareScreenCanvas.transform);
            //shareViewCloseButton.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().CloseView(PhotonNetwork.LocalPlayer); });
            shareViewCloseButton = shareScreenCanvas.transform.Find("CloseViewButton").gameObject;
            shareViewCloseButton.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().CloseView(PhotonNetwork.LocalPlayer); });
            shareViewCloseButton.SetActive(true);
            Debug.Log("share success");

            //foreach(GameObject child in shareScreenController.GetComponent<ShareCanvas>().gameObjects)
            //{
            //    if (child.GetComponent<Canvas>())
            //    {
            //        child.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
            //        child.GetComponent<Canvas>().worldCamera = hostCam;
            //        child.GetComponent<Canvas>().sortingOrder = 1;
            //    }
            //    else if (child.transform.GetChild(0).GetComponent<Canvas>())
            //    {
            //        for (int i = 0; i < child.transform.childCount; i++)
            //        {
            //            child.transform.GetChild(i).GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
            //            child.transform.GetChild(i).GetComponent<Canvas>().worldCamera = hostCam;
            //            child.transform.GetChild(i).GetComponent<Canvas>().sortingOrder = 1;
            //        }
            //    }
            //}

            foreach (Canvas canvas in shareScreenCanvas.GetComponent<ShareCanvas>().shareableCanvases)
            {
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = hostCam;
                canvas.sortingOrder = 1;
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
            //foreach (GameObject child in shareScreenController.GetComponent<ShareCanvas>().gameObjects)
            //{
            //    if (child.GetComponent<Canvas>())
            //        child.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            //    else if (child.transform.GetChild(0).GetComponent<Canvas>())
            //    {
            //        for (int i = 0; i < child.transform.childCount; i++)
            //        {
            //            child.transform.GetChild(i).GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            //        }
            //    }
            //}
           

            foreach (Canvas canvas in shareScreenCanvas.GetComponent<ShareCanvas>().shareableCanvases)
            {
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            }

            shareScreenCanvas.GetComponent<ShareCanvas>().SetActiveStateOfCanvases(savedActiveCanvas);
            //shareScreenCanvas.GetComponent<ShareScene>().SetActiveScenes(savedActiveScenes, savedActiveItems);

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
