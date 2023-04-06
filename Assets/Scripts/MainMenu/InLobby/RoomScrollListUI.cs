using Photon.Realtime;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomScrollListUI : MonoBehaviour
{
    [SerializeField] Transform createRoomTransform;
    [Space]
    [SerializeField] ScrollHelper<RoomScrollItem> roomList;

    public void UpdateRoomScrollList(List<RoomInfo> roomInfos)
    {
        List<RoomInfo> joinableRoomList = RemoveEmptyRooms(roomInfos);
        UpdatePrefabs(joinableRoomList);

        createRoomTransform.SetAsLastSibling();
    }

    private List<RoomInfo> RemoveEmptyRooms(List<RoomInfo> roomInfos)
    {
        //Playfab still show empty rooms for whatever reason so have to remove manually
        //Player cant join a room that has no players
        for (int i = roomInfos.Count - 1; i >= 0; i--)
        {
            if (roomInfos[i].PlayerCount == 0)
                roomInfos.RemoveAt(i);
        }
        return roomInfos;
    }

    private void UpdatePrefabs(List<RoomInfo> joinableRoomList)
    {
        roomList.FillContentWithCorrectNumberOfPrefabs(joinableRoomList.Count);

        for (int i = 0; i < joinableRoomList.Count; i++)
        {
            roomList.spawnedPrefabComponents[i].SetRoomInfo(joinableRoomList[i]);
        }
    }
}
