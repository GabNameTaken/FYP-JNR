using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerListEntries : MonoBehaviourPunCallbacks
{
    public delegate void OnPlayerListEntriesUpdate();
    public OnPlayerListEntriesUpdate onPlayerListEntriesUpdate;

    private readonly Dictionary<int, Player> playerListEntries = new Dictionary<int, Player>();

    public Dictionary<int, Player> GetPlayerEntries()
    {
        return playerListEntries;
    }

    public override void OnJoinedRoom()
    {
        foreach (Player p in PhotonNetwork.PlayerList)
        {
            playerListEntries.Add(p.ActorNumber, p);
        }

        Debug.Log("JoinedRoom INVOKE!");
        onPlayerListEntriesUpdate?.Invoke();
    }
    public override void OnLeftRoom()
    {
        playerListEntries.Clear();
        
        Debug.Log("LeftRoom INVOKE!");
        onPlayerListEntriesUpdate?.Invoke();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        playerListEntries.Add(newPlayer.ActorNumber, newPlayer);

        Debug.Log("PlayerEnteredRoom INVOKE!");
        onPlayerListEntriesUpdate?.Invoke();
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        playerListEntries.Remove(otherPlayer.ActorNumber);

        Debug.Log("PlayerLeftRoom INVOKE!");
        onPlayerListEntriesUpdate?.Invoke();
    }
}
