using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerName : MonoBehaviour
{
    private TextMeshProUGUI username;
    void Start()
    {
        username = GetComponent<TextMeshProUGUI>();
        username.text = PhotonNetwork.NickName;
    }
}
