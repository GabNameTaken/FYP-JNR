using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(NetworkController))]
public class QuickRoomSetup : MonoBehaviourPunCallbacks
{
    // Intended for developer use
    // To allow us to test game scene without having to go thru the entire lobby system

    private void Awake()
    {
        // to make sure we dont use this if the user is already connected (assume that they came from lobby)
        if (PhotonNetwork.IsConnectedAndReady)
            gameObject.SetActive(false);
    }

    public override void OnConnectedToMaster()
    {
        if (PhotonNetwork.OfflineMode)
            OnJoinedLobby();
        else
            PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
}
