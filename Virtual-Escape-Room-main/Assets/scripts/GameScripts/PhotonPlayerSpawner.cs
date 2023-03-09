using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonPlayerSpawner : MonoBehaviourPunCallbacks
{
    private PhotonView thisPV;
    public override void OnEnable()
    {
        base.OnEnable();

        StartGame();
    }
    public override void OnDisable()
    {
        base.OnDisable();
    }
    public override void OnJoinedRoom()
    {
        StartGame();
    }

    private void StartGame()
    {
        GameObject thisPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
        thisPV = thisPlayer.GetComponent<PhotonView>();
    }

    public PhotonView GetThisPV()
    {
        return thisPV;
    }
}
