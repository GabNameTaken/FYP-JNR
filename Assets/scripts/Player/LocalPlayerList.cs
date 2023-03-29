using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LocalPlayerList : MonoBehaviour
{
    public List<GameObject> PlayerList = new();

    public int AddPlayer(GameObject newPlayer)
    {
        PlayerList.Add(newPlayer);

        return PlayerList.IndexOf(newPlayer);
    }

    public GameObject FindPlayer(int playerNum)
    {
        return PlayerList[playerNum];
    }

    public int FindIndex(GameObject player)
    {
        return PlayerList.IndexOf(player);
    }

    private void Update()
    {
        for (int i = 0; i < PlayerList.Count; i++)
        {
            if (PlayerList[i] == null)
                PlayerList.RemoveAt(i);
        }
    }
}
