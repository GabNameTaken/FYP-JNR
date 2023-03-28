using UnityEngine;
using Photon.Pun;

public class PhotonPlayerSpawner : MonoBehaviourPunCallbacks
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
        if (PhotonNetwork.IsMasterClient)
        {
            GameObject thisPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
            GameObject Network = GameObject.Find("Network");
            //thisPlayer.GetComponent<PlayerInfo>().playerNum = Network.GetComponent<LocalPlayerList>().AddPlayer(thisPlayer);
            //Debug.Log(thisPlayer.GetComponent<PlayerInfo>().playerNum);
        }
    }
}
