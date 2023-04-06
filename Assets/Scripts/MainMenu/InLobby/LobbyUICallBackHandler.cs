using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyUICallBackHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] RoomScrollListUI roomScrollListUI;

    [SerializeField] NavigationPage navigationPage;
    [SerializeField] VideoBackgroundPage nextPage;

    [SerializeField] RoomCache roomCache;

    public override void OnEnable()
    {
        base.OnEnable();

        roomCache.onCachedRoomListUpdate += UpdateScrollListUI;

        if (PhotonNetwork.InLobby)
        {
            UpdateScrollListUI();
        }
    }

    public override void OnDisable()
    {
        base.OnDisable();

        roomCache.onCachedRoomListUpdate -= UpdateScrollListUI;
    }

    public override void OnJoinedRoom()
    {
        ChangePage();
    }

    private void ChangePage()
    {
        navigationPage.PushPage(nextPage);
    }

    private void UpdateScrollListUI()
    {
        List<RoomInfo> roomList = new List<RoomInfo>();

        foreach (RoomInfo info in roomCache.GetCachedRoomList().Values)
        {
            roomList.Add(info);
        }

        roomScrollListUI.UpdateRoomScrollList(roomList);
    }
}
