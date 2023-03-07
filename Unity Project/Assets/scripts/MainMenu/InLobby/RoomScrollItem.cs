using UnityEngine;
using TMPro;
using Photon.Realtime;
using System.Collections.Generic;

public class RoomScrollItem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI roomName;
    [SerializeField] TextMeshProUGUI roomCapacity;

    [SerializeField] GameObject playerScrollListUI;
    [SerializeField] ScrollHelper<TextMeshProUGUI> playerScrollListHelper;

    List<string> names;

    public void OnEnable()
    {
    }

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        roomName.text = roomInfo.Name;
        roomCapacity.text = roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers;
        names = PlayerListEntries.ReadPlayerListFromRoomProperty(roomInfo.CustomProperties);
        PrintNames(PlayerListEntries.ReadPlayerListFromRoomProperty(roomInfo.CustomProperties));

        playerScrollListUI.SetActive(true);
        CreatePlayerScrollList();
        PrintNames(names);
        playerScrollListUI.SetActive(false);
    }

    public void OnClick_JoinRoom()
    {
        CreateJoinRoomManager.instance.TryJoinRoom(roomName.text);
    }

    public void ShowPlayers()
    {
        PrintNames(names);

        playerScrollListUI.SetActive(!playerScrollListUI.activeSelf);
    }

    private void CreatePlayerScrollList()
    {
        playerScrollListHelper.FillContentWithCorrectNumberOfPrefabs(names.Count);
        for (int i = 0; i < names.Count; i++)
        {
            playerScrollListHelper.spawnedPrefabComponents[i].text = names[i];
        }
    }

    private void PrintNames(List<string> list)
    {
        Debug.Log("print names pls");
        foreach (string name in list)
        {
            Debug.Log(name);
        }
    }
}
