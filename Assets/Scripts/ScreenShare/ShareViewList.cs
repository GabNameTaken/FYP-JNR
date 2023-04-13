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
    private PhotonView photonView;
    private Player client;

    void Start()
    {
        listOpen = false;
        shareViewList = transform.parent.parent.gameObject;
        shareViewList.SetActive(false);
        
        photonView = photonPlayer.GetPlayerPhotonView();
    }

    public void ListShareScreen()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            client = PhotonNetwork.LocalPlayer;
            photonView.RPC("UpdateShareList", RpcTarget.AllViaServer, client);
            Debug.Log(client.NickName + "," + client.ActorNumber  + ":" + photonView.ViewID);
        }
    }

    public void ViewPlayerScreen(Player host)
    {
        Debug.Log("Viewing: " + host.NickName);
        photonView.RPC("CallShareScreen", host, PhotonNetwork.LocalPlayer);
        photonView.RPC("ListViewer", host,PhotonNetwork.LocalPlayer);
    }

    public void CloseView(Player player)
    {
        photonView.RPC("CloseViewScreen", player);
        photonView.RPC("RemoveViewer", RpcTarget.AllViaServer,PhotonNetwork.LocalPlayer);
        Debug.Log("Exiting view for " + player.NickName);
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
