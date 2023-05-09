using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using Photon.Pun;
using Photon.Realtime;

public class ShareViewList : MonoBehaviour
{
    [SerializeField] private GameObject playerButton;
    private GameObject shareViewList;

    private bool listOpen;

    [SerializeField] private SceneGameManager photonPlayer;
    [SerializeField] private GameObject shareScreen;
    public List<GameObject> disableGOs;
    private PhotonView photonView;
    private Player client;
    private GameObject toggle;

    void Start()
    {
        listOpen = false;
        shareViewList = transform.parent.parent.parent.gameObject;
        shareViewList.SetActive(false);
        
        photonView = photonPlayer.GetPlayerPhotonView();
    }

    private void Awake()
    {
        toggle = GameObject.Find("ConferenceCanvas").transform.Find("DropDownPanel").transform.Find("HorizontalVideoView").transform.Find("ShareScreenToggle").gameObject;
        toggle.GetComponent<Button>().onClick.AddListener(delegate { ListShareScreen(); });
        toggle.SetActive(true);
    }

    public void ListShareScreen()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            client = PhotonNetwork.LocalPlayer;
            photonView.RPC("UpdateShareList", RpcTarget.AllViaServer, client);

            toggle.transform.GetChild(0).gameObject.SetActive(false);
            toggle.transform.GetChild(1).gameObject.SetActive(true);
            toggle.GetComponent<Button>().onClick.RemoveAllListeners();
            toggle.GetComponent<Button>().onClick.AddListener(delegate { StopShareScreen(); });

            Debug.Log(client.NickName + "," + client.ActorNumber  + ":" + photonView.ViewID);
        }
    }

    public void StopShareScreen()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            client = PhotonNetwork.LocalPlayer;
            photonView.RPC("DestroyShareList", RpcTarget.AllViaServer, client);
            photonView.RPC("RemoveAllViewers", client);

            toggle.transform.GetChild(0).gameObject.SetActive(true);
            toggle.transform.GetChild(1).gameObject.SetActive(false);
            toggle.GetComponent<Button>().onClick.RemoveAllListeners();
            toggle.GetComponent<Button>().onClick.AddListener(delegate { ListShareScreen(); });
        }
    }

    public void ViewPlayerScreen(Player host)
    {
        Debug.Log("Viewing: " + host.NickName);
        CloseView(PhotonNetwork.LocalPlayer);
        photonView.RPC("PreShareScreen", PhotonNetwork.LocalPlayer);
        photonView.RPC("CallShareScreen", host, PhotonNetwork.LocalPlayer);
        shareScreen.SetActive(true);
        foreach (GameObject go in disableGOs)
        {
            go.SetActive(false);
        }
    }

    public void CloseView(Player player)
    {
        photonView.RPC("CloseViewScreen", player);
        photonView.RPC("RemoveViewer", RpcTarget.AllViaServer, player);
        Debug.Log("Exiting view for " + PhotonNetwork.LocalPlayer.NickName);
    }

    public void ShareButtonHandler()
    {
        if (listOpen == false)
        {
            shareViewList.SetActive(true);
            listOpen = true;
        }
        else
        {
            shareViewList.SetActive(false);
            listOpen = false;
        }
    }
}
