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
    private Camera cam;
    private Button shareButton, closeButton;
    [SerializeField] private GameObject sharePlayerButton;
    public bool viewing;
    private GameObject shareViewList;
    [SerializeField] private GameObject playerButton;

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();
        //shareButton = GameObject.Find("ShareButton").GetComponent<Button>();
        closeButton = GameObject.Find("CloseButton").GetComponent<Button>();
        if (photonView.IsMine)
        {
            closeButton.onClick.AddListener(CloseScreen);
            closeButton.interactable = false;
            Color col = closeButton.GetComponent<Image>().color;
            col.a = 0;
            closeButton.GetComponent<Image>().color = col;
        }
        else
        {
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
            //Destroy(cam.GetComponent<CCameraControls>());
            //Destroy(cam.GetComponent<CRaycastOnClick>());
        }

        
        shareViewList = GameObject.FindGameObjectWithTag("ShareScreenCanvas").transform.Find("SharedList").transform.Find("Viewport").transform.Find("Content").gameObject;
    }

    [PunRPC]
    public void UpdateShareList(string name, Player host)
    {
        //shareViewList = GameObject.FindGameObjectWithTag("ShareScreenCanvas").transform.Find("SharedList").transform.Find("Viewport").transform.Find("Content").gameObject;
        //GameObject go = PhotonNetwork.Instantiate("SharePlayerButton", gameObject.transform.position, Quaternion.identity);
        GameObject go = Instantiate(playerButton, shareViewList.transform);
        go.GetComponentInChildren<TextMeshProUGUI>().text = name;
        go.GetComponent<Button>().onClick.AddListener(delegate { shareViewList.GetComponent<ShareViewList>().ViewPlayerScreen(host); });
    }

    [PunRPC]
    public void CallShareScreen(Player target)
    {
        photonView.RPC("ShareScreen", target);
    }

    [PunRPC]
    public void ShareScreen()
    {
        cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        cam.rect = new Rect(0.05f, 0.05f, 0.9f, 0.9f);
        myCam.depth = 1;

        shareButton.gameObject.SetActive(false);
        closeButton.interactable = true;
        Color col = closeButton.GetComponent<Image>().color;
        col.a = 1;
        closeButton.GetComponent<Image>().color = col;
    }

    public void CloseScreen()
    {
        closeButton.interactable = false;
        Color col = closeButton.GetComponent<Image>().color;
        col.a = 0;
        closeButton.GetComponent<Image>().color = col;
        shareButton.gameObject.SetActive(true);
        myCam.depth = 1;
    }
}
