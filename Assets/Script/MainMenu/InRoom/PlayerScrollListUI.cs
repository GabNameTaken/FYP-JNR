using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrollListUI : MonoBehaviour
{
    [SerializeField] ScrollHelper<NameScrollItem> playerNameList;

    public void UpdatePlayerList(List<KeyValuePair<string, bool>> playerList)
    {
        playerNameList.FillContentWithCorrectNumberOfPrefabs(playerList.Count);

        for (int i = 0; i < playerList.Count; i++)
        {
            playerNameList.spawnedPrefabComponents[i].SetPlayerName(playerList[i].Key);
            playerNameList.spawnedPrefabComponents[i].SetPlayerReadyStatus(playerList[i].Value);
        }
    }

    public void ClearPlayerList()
    {
        playerNameList.FillContentWithCorrectNumberOfPrefabs(0);
    }
}
