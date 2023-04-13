using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RoomUICallBacksHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] PlayerScrollListUI playerScrollListUI;
    [SerializeField] TextMeshProUGUI roomNameDisplay;

    [SerializeField] SessionManager sessionManager;
    //[SerializeField] NavigationPage navigationPage;
    [SerializeField] GameObject prevPage;
    public override void OnEnable()
    {
        base.OnEnable();

        sessionManager.onJoinedSessionSuccess += ChangePage;
        PlayerListEntries.instance.onPlayerListEntriesUpdate += UpdateNameListUI;

        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }
    }
    public override void OnDisable()
    {
        base.OnDisable();

        sessionManager.onJoinedSessionSuccess -= ChangePage;
        PlayerListEntries.instance.onPlayerListEntriesUpdate -= UpdateNameListUI;
    }
    #region Button Functions

    public void OnLeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        ClearNameListUI();
    }

    #endregion

    #region Override Functions
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined: " + PhotonNetwork.CurrentRoom.Name);

        roomNameDisplay.text = PhotonNetwork.CurrentRoom.Name;

        UpdateNameListUI();
    }
    public override void OnConnectedToMaster()
    {
        sessionManager.RejoinSession();
    }
    public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
    {
        UpdateNameListUI();
    }

    #endregion

    private void ChangePage()
    {
        //navigationPage.PopPage();
        prevPage.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    private void UpdateNameListUI()
    {
        playerScrollListUI.UpdatePlayerList(GetNameListOfPlayersInRoom());
    }

    private void ClearNameListUI()
    {
        playerScrollListUI.ClearPlayerList();
    }

    private List<KeyValuePair<string, bool>> GetNameListOfPlayersInRoom()
    {
        List<KeyValuePair<string, bool>> playerList = new List<KeyValuePair<string, bool>>();

        foreach (KeyValuePair<int, Player> player in PlayerListEntries.instance.GetPlayerEntries())
        {
            string playerName = player.Value.NickName;

            player.Value.CustomProperties.TryGetValue(ReadySystem.PLAYER_READY, out object readyProperty);
            bool playerReadyStatus = readyProperty == null ? false : (bool)readyProperty;

            KeyValuePair<string, bool> keyValuePair = new(playerName, playerReadyStatus);
            playerList.Add(keyValuePair);
        }

        return playerList;
    }
}
