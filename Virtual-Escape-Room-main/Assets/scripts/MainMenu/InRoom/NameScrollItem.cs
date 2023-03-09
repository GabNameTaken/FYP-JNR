using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameScrollItem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;
    [SerializeField] GameObject readyBackground;
    [SerializeField] GameObject unreadyBackground;


    public void SetPlayerName(string playerName)
    {
        this.playerName.text = playerName;
    }

    public void SetPlayerReadyStatus(bool status)
    {
        readyBackground.SetActive(status);
        unreadyBackground.SetActive(!status);
    }
}
