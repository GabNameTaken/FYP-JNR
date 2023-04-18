using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SessionInfoUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI size;

    [SerializeField] SessionManager sessionManager;
    [SerializeField] SessionSize sessionSize;
    [SerializeField] RoomCache roomCache;

    int maxPlayers = 0;
    private void OnEnable()
    {
        roomCache.onCachedRoomListUpdate += UpdateSizeField;
    }
    private void OnDisable()
    {
        roomCache.onCachedRoomListUpdate -= UpdateSizeField;
    }

    private void Start()
    {

        maxPlayers = sessionManager.GetSessionInfo().MaxPlayers;

        UpdateSizeField();
    }

    private void UpdateSizeField()
    {
        size.text = "players in rooms: " + sessionSize.GetPlayerCount().ToString() + "/" + maxPlayers.ToString();
    }
}
