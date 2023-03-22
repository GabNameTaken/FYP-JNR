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

    [SerializeField] private PhotonPlayerSpawner photonPlayer;
    private PhotonView photonView;
    private Player client;
    private string playerName;

    void Start()
    {
        listOpen = false;
        shareViewList = transform.parent.parent.gameObject;
        shareViewList.SetActive(false);
        photonView = photonPlayer.GetThisPV();
    }

    //private void UpdateShareList()
    //{
    //    Debug.Log(photonView.ViewID.ToString());
    //    foreach (Player player in PhotonNetwork.PlayerListOthers)
    //    {
    //        GameObject go = Instantiate(playerButton, gameObject.transform);
    //        go.GetComponentInChildren<TextMeshProUGUI>().text = player.NickName;
    //        go.GetComponent<Button>().onClick.AddListener(delegate { CallShareScreen(player); });
    //    }
    //}

    public void ListShareScreen()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            playerName = PhotonNetwork.LocalPlayer.NickName;
            client = PhotonNetwork.LocalPlayer;
            photonView.RPC("UpdateShareList", RpcTarget.AllViaServer, playerName, client);
        }
        //UpdateShareList(playerName);
    }

    public void ViewPlayerScreen(Player host)
    {
        photonView.RPC("CallShareScreen", host, PhotonNetwork.LocalPlayer);
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
