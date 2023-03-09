using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class ShareView : MonoBehaviour
{
    private PhotonView photonView;
    [SerializeField] private Camera cam, myCam;
    private Button shareButton, closeButton;
    [SerializeField] private GameObject sharePlayerButton;

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
