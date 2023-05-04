using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SyncTimer : MonoBehaviour
{
    PhotonView photonView;
    GameTimer timer;
    private void Start()
    {
        photonView = GetComponent<PhotonView>();
        timer = GameObject.Find("Canvas").transform.Find("Level Timer").GetComponent<GameTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            photonView.RPC("DisplayTime", RpcTarget.All, timer.CurrentTimeSeconds);
        }
    }
}
