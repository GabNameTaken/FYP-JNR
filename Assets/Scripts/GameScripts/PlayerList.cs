using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerList : MonoBehaviour
{
    [SerializeField] ObjectPooler<TextMeshProUGUI> playerScrollListSpawner;

    bool opened;

    private void Start()
    {
        opened = false;
    }
    public void OnClick_ListPlayers()
    {
        opened = !opened;

        if (opened)
            GenerateList();
        else
            RemoveList();
    }

    private void GenerateList()
    {
        List<string> playerList = GetNameListOfPlayersInRoom();

        Debug.Log("Hello: " + playerList);

        for (int i = 0; i < playerList.Count; i++)
        {
            playerScrollListSpawner.FetchComponent().text = playerList[i];
        }
    }

    private void RemoveList()
    {
        for (int i = playerScrollListSpawner.gameObjects.Count; i > 0;)
        {
            ObjectPooler<TextMeshProUGUI>.ReturnGO(playerScrollListSpawner.gameObjects[--i]);
        }
    }

    private List<string> GetNameListOfPlayersInRoom()
    {
        List<string> playerList = new();

        foreach (KeyValuePair<int, Photon.Realtime.Player> player in PlayerListEntries.instance.GetPlayerEntries())
        {
            string playerName = player.Value.NickName;
            playerList.Add(playerName);
        }

        return playerList;
    }
}
