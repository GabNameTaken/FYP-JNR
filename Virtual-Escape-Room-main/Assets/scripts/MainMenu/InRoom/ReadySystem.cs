using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Photon.Pun;
using ExitGames.Client.Photon;
using System;
using Photon.Realtime;

public class ReadySystem : MonoBehaviourPunCallbacks
{
    public const string PLAYER_READY = "IsPlayerReady";

    bool isPlayerReady = false;

    [SerializeField] UnityEvent OnReady;
    [SerializeField] UnityEvent OnUnready;

    public void InitialiseReadyProperty()
    {
        isPlayerReady = false;
        Hashtable initialProps = new Hashtable() { {PLAYER_READY, isPlayerReady }};
        PhotonNetwork.LocalPlayer.SetCustomProperties(initialProps);
    }

    public bool AllPlayersAreReady()
    {
        foreach (KeyValuePair<int, Player> player in PlayerListEntries.instance.GetPlayerEntries())
        {
            object isReady;
            player.Value.CustomProperties.TryGetValue(PLAYER_READY, out isReady);
            if (!(bool)isReady)
                return false;
        }

        Debug.Log("All ready");

        return true;
    }

    public void OnClick_Ready()
    {
        isPlayerReady = !isPlayerReady;

        Hashtable props = new Hashtable() { { PLAYER_READY, isPlayerReady } };
        PhotonNetwork.LocalPlayer.SetCustomProperties(props);

        Debug.Log("Set player ready");
    }

    public override void OnJoinedRoom()
    {
        InitialiseReadyProperty();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        SetPlayerUneady();
    }

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        changedProps.TryGetValue(PLAYER_READY, out object readyProperty);

        bool ready = readyProperty == null ? false : (bool)readyProperty;

        if (PhotonNetwork.IsMasterClient)
        { // only need to run once
            if (ready && AllPlayersAreReady())
                SetPlayerReady();
            else
                SetPlayerUneady();
        }
    }

    private void SetPlayerReady()
    {
        OnReady?.Invoke();
    }
    private void SetPlayerUneady()
    {
        OnUnready?.Invoke();
    }
}
