using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;
using ExitGames.Client.Photon;

public class PlayerListEntries : MonoSingletonTemplate<PlayerListEntries>, IInRoomCallbacks, IMatchmakingCallbacks
{
    public delegate void OnPlayerListEntriesUpdate();
    public OnPlayerListEntriesUpdate onPlayerListEntriesUpdate;

    private readonly Dictionary<int, Player> playerListEntries = new();

    public const string PLAYER_LIST = "PlayerList";
    private const string VALUE_SEPERATOR = ",";

    private void Awake()
    {
        InitializeSingleton(this);
        PhotonNetwork.AddCallbackTarget(this);
    }

    public Dictionary<int, Player> GetPlayerEntries()
    {
        return playerListEntries;
    }

    public void OnJoinedRoom()
    {
        foreach (Player p in PhotonNetwork.PlayerList)
        {
            playerListEntries.Add(p.ActorNumber, p);
        }

        onPlayerListEntriesUpdate?.Invoke();

        if (PhotonNetwork.IsMasterClient)
        {
            WritePlayerListToRoomProperty();
        }
    }
    public void OnLeftRoom()
    {
        playerListEntries.Clear();
        
        onPlayerListEntriesUpdate?.Invoke();
    }
    public void OnPlayerEnteredRoom(Player newPlayer)
    {
        playerListEntries.Add(newPlayer.ActorNumber, newPlayer);

        onPlayerListEntriesUpdate?.Invoke();

        if (PhotonNetwork.IsMasterClient)
        {
            WritePlayerListToRoomProperty();
        }
    }
    public void OnPlayerLeftRoom(Player otherPlayer)
    {
        playerListEntries.Remove(otherPlayer.ActorNumber);

        onPlayerListEntriesUpdate?.Invoke();

        if (PhotonNetwork.IsMasterClient)
        {
            WritePlayerListToRoomProperty();
        }
    }

    private void WritePlayerListToRoomProperty()
    {
        string playerNameList = "";

        foreach (KeyValuePair<int, Player> player in playerListEntries)
        {
            playerNameList += player.Value.NickName;
            playerNameList += VALUE_SEPERATOR;
        }

        Hashtable initialProps = new Hashtable() { { PLAYER_LIST, playerNameList } };
        PhotonNetwork.CurrentRoom.SetCustomProperties(initialProps);
    }

    public static List<string> ReadPlayerListFromRoomProperty(Hashtable roomProperties)
    {
        List<string> playerNames = new();
        roomProperties.TryGetValue(PLAYER_LIST, out object playerNameListObject);
        string playerNameList = (string)playerNameListObject;
        while (!string.IsNullOrEmpty(playerNameList) && playerNameList.Contains(VALUE_SEPERATOR))
        {
            int seperatorIndex = playerNameList.IndexOf(VALUE_SEPERATOR);
            string playerName = playerNameList.Remove(seperatorIndex);
            playerNameList = playerNameList.Substring(seperatorIndex + 1);
            playerNames.Add(playerName);
            Debug.Log(playerNameList);
        }

        return playerNames;
    }

    #region unused interface implementations
    public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
    {
    }

    public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
    }

    public void OnMasterClientSwitched(Player newMasterClient)
    {
    }

    public void OnFriendListUpdate(List<FriendInfo> friendList)
    {
    }

    public void OnCreatedRoom()
    {
    }

    public void OnCreateRoomFailed(short returnCode, string message)
    {
    }

    public void OnJoinRoomFailed(short returnCode, string message)
    {
    }

    public void OnJoinRandomFailed(short returnCode, string message)
    {
    }
    #endregion
}
