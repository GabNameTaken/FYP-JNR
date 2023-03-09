using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;

public class RoomCache : MonoBehaviourPunCallbacks
{
    private readonly Dictionary<string, RoomInfo> cachedRoomList = new Dictionary<string, RoomInfo>();


    public delegate void OnCachedRoomListUpdate();
    public OnCachedRoomListUpdate onCachedRoomListUpdate;

    #region override functions

    public override void OnJoinedLobby()
    {
        cachedRoomList.Clear();
    }

    public override void OnLeftLobby()
    {
        // note: when a client joins / creates a room, OnLeftLobby does not get called, even if the client was in a lobby before
        cachedRoomList.Clear();
    }

    public override void OnJoinedRoom()
    {
        // joining (or entering) a room invalidates any cached lobby room list (even if LeaveLobby was not called due to just joining a room)
        cachedRoomList.Clear();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        UpdateCachedRoomList(roomList);

        InvokeEvents();
    }

    #endregion

    public Dictionary<string, RoomInfo> GetCachedRoomList()
    {
        return cachedRoomList;
    }

    private void InvokeEvents()
    {
        onCachedRoomListUpdate?.Invoke();
    }

    private void UpdateCachedRoomList(List<RoomInfo> roomList)
    {
        foreach (RoomInfo info in roomList)
        {
            if (RoomIsClosedOrRemovedOrInvisible(info))
            {
                RemoveClosedOrInvisibleOrRemovedRoom(info);

                continue;
            }

            AddOrUpdateRoom(info);
        }
    }

    private static bool RoomIsClosedOrRemovedOrInvisible(RoomInfo info)
    {
        return !info.IsOpen || !info.IsVisible || info.RemovedFromList;
    }

    private void RemoveClosedOrInvisibleOrRemovedRoom(RoomInfo info)
    {
        if (cachedRoomList.ContainsKey(info.Name))
        {
            cachedRoomList.Remove(info.Name);
        }
    }

    private void AddOrUpdateRoom(RoomInfo info)
    {
        if (cachedRoomList.ContainsKey(info.Name))
        {
            cachedRoomList[info.Name] = info;
        }
        else
        {
            cachedRoomList.Add(info.Name, info);
        }
    }
}
