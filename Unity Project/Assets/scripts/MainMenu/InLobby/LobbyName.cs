using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class LobbyName : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lobbyNameDisplay;

    private void Start()
    {
        UpdateNameDisplay();
    }

    private void UpdateNameDisplay()
    {
        lobbyNameDisplay.text = PhotonNetwork.OfflineMode ?
            "Offline"                      
            : PhotonNetwork.CurrentLobby.Name;
    }
}
