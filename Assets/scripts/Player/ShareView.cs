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
    private GameObject shareViewList;
    private GameObject localPlayerList;
    [SerializeField] private GameObject playerButton;
    [SerializeField] private GameObject sharedCamera;

    // Start is called before the first frame update
    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (!photonView.IsMine)
            cam = gameObject.transform.Find("Camera").gameObject.GetComponent<Camera>();
        localPlayerList = GameObject.Find("Network");
        shareViewList = GameObject.FindGameObjectWithTag("ShareScreenCanvas").transform.Find("SharedList").transform.Find("Viewport").transform.Find("Content").gameObject;
    }

    [PunRPC]
    public void CallShareScreen(Player viewer)
    {
        Debug.Log(viewer.NickName);
        if (photonView.IsMine)
        {
            photonView.RPC("ShareScreen", viewer, localPlayerList.GetComponent<LocalPlayerList>().FindIndex(gameObject));
            Debug.Log("ran boi");
        }
    }

    [PunRPC]
    public void ShareScreen(int index)
    {
        Debug.Log(index);
        GameObject host = GameObject.Find("Network").GetComponent<LocalPlayerList>().FindPlayer(index);
        if (host != null)
        {
            cam = host.transform.Find("Camera").gameObject.GetComponent<Camera>();
            cam.rect = new Rect(0.05f, 0.05f, 0.9f, 0.9f);
            myCam.depth = 1;
        }
    }

    public void CloseScreen()
    {
        myCam.depth = 1;
    }
}
