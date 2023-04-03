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

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine)
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        localPlayerList = GameObject.Find("Network").GetComponent<LocalPlayerList>();
        shareScreenCanvas = GameObject.FindGameObjectWithTag("ShareScreenCanvas");
        shareViewList = shareScreenCanvas.transform.Find("SharedList").transform.Find("Viewport").transform.Find("Content").gameObject;
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
            hostCam.depth = -1;
            myCam.depth = 1;
            gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>().depth = 1;
            shareViewCloseButton = Instantiate(shareViewClosePrefab,shareScreenCanvas.transform);
            shareViewCloseButton.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().CloseView(PhotonNetwork.LocalPlayer); });
            Debug.Log("share success");
        }
    }

    [PunRPC]
    public void CloseViewScreen()
    {
        if (host != null)
        {
            Camera hostCam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            hostCam.rect = new Rect(0f,0f,1f,1f);
            hostCam.depth = 0;
            myCam.depth = -1;
            Destroy(shareViewCloseButton);
        }
        gameObject.SetActive(true);
        
        Debug.Log("Closed Screen");
    }
}
