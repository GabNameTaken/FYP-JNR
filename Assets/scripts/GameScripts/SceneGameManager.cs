using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SceneGameManager : MonoBehaviourPunCallbacks
{
    public override void OnEnable()
    {
        base.OnEnable();

        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }
    }
    public override void OnJoinedRoom()
    {
        StartGame();
    }

    private void StartGame()
    {
        if (PhotonNetwork.LocalPlayer.IsLocal)
        {
            if (PlayerManager.localPlayer == null)
            {
                GameObject thisPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
                GameObject Network = GameObject.Find("Network");
                Network.GetComponent<LocalPlayerList>().AddPlayer(thisPlayer);
                Debug.Log(Network.GetComponent<LocalPlayerList>().PlayerList.Count);
                for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
                    Debug.Log(PhotonNetwork.PlayerList[i]);
            }
        }
    }
}
