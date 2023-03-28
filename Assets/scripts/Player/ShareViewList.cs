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

    public PhotonView photonView;
    private Player client;

    void Start()
    {
        listOpen = false;
        shareViewList = transform.parent.parent.gameObject;
        shareViewList.SetActive(false);
    }

    public void ListShareScreen()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            client = PhotonNetwork.LocalPlayer;
            photonView.RPC("UpdateShareList", RpcTarget.AllViaServer, client);
            Debug.Log(client.NickName);
        }
    }

    [PunRPC]
    public void UpdateShareList(Player host)
    {
        GameObject go = Instantiate(playerButton, gameObject.transform);
        go.GetComponentInChildren<TextMeshProUGUI>().text = host.NickName;
        go.GetComponent<Button>().onClick.AddListener(delegate { ViewPlayerScreen(host); });
    }

    public void ViewPlayerScreen(Player host)
    {
        Debug.Log(host.NickName);
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
