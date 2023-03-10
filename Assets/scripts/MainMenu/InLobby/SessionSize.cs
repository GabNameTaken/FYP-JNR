using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

// Use the number of players in the room list cache to check due to limitations with viewing stats and properties in a lobby.
// Intended to be used when in a lobby only
public class SessionSize : MonoBehaviour
{
    [SerializeField] RoomCache roomCache;
    [SerializeField] SessionManager sessionManager;

    public bool RoomsAreFull()
    {
        return sessionManager.GetMaxPlayers() < GetPlayerCount();
    }

    public int GetPlayerCount()
    {
        int playerCount = 0;

        foreach (KeyValuePair<string, RoomInfo> roomInfo in roomCache.GetCachedRoomList())
        {
            playerCount += roomInfo.Value.PlayerCount;
        }

        return playerCount;
    }
}
