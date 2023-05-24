using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneNavigation : MonoBehaviour
{
    [SerializeField] GameObject scene;
    [SerializeField] GameObject itemHolder;
    [SerializeField] TextMeshProUGUI roomName;

    [SerializeField] private Dictionary<string, GameObject> items = new();
    [SerializeField] private Dictionary<string, GameObject> rooms = new();

    private List<string> listOfArrows = new()
    {
        "Arrow_Office1",
        "Arrow_Office2",
        "Arrow_Office3",
        "Arrow_OfficePrinter",
        "Arrow_OfficeMeetingRoom",
        "Arrow_OfficePantry1",
        "Arrow_OfficePantry",
        "Arrow_BossRoom",
        "Arrow_Reception",
        "Arrow_Lobby",
        "Arrow_Floor1Lobby",
        "Arrow_Lift",
        "Arrow_EntranceLobby1",
        "Arrow_EntranceLobby2",
        "Arrow_EntranceLobby3",
        "Arrow_LoungeHall",
        "Arrow_Lounge",
        "Arrow_LoungeKitchen",
        "Arrow_LobbyMeetingRoom1",
        "Arrow_LobbyMeetingRoom2"
    };

    Dictionary<string, string> roomNames = new Dictionary<string, string>
    {
        { "Arrow_Office1", "Office room" },
        { "Arrow_Office2", "Office room 2" },
        { "Arrow_Office3", "Office room 3" },
        { "Arrow_OfficePrinter", "Office printer" },
        { "Arrow_OfficeMeetingRoom", "Office meeting room" },
        { "Arrow_OfficePantry1", "Office pantry" },
        { "Arrow_OfficePantry", "Office kitchen" },
        { "Arrow_BossRoom", "Boss room" },
        { "Arrow_Reception", "Reception"},
        { "Arrow_Lobby", "Lift lobby"},
        { "Arrow_Floor1Lobby", "Lobby" },
        { "Arrow_Lift", "Lift"},
        { "Arrow_EntranceLobby1", "Entrance lobby"},
        { "Arrow_EntranceLobby2", "Entrance lobby 2"},
        { "Arrow_EntranceLobby3", "Entrance lobby 3"},
        { "Arrow_LoungeHall", "Lounge hall"},
        { "Arrow_Lounge", "Lounge"},
        { "Arrow_LoungeKitchen", "Lounge kitchen"},
        { "Arrow_LobbyMeetingRoom1", "Lobby meeting room"},
        { "Arrow_LobbyMeetingRoom2", "Lobby meeting room 2"}
    };

    private void Start()
    {
        for (byte i = 0; i < scene.transform.childCount; i++)
        {
            rooms.Add(scene.transform.GetChild(i).name, scene.transform.GetChild(i).gameObject);
        }

        for (byte i = 0; i < itemHolder.transform.childCount; i++)
        {
            items.Add(itemHolder.transform.GetChild(i).name, itemHolder.transform.GetChild(i).gameObject);
        }
    }
    public void ChangeSceneWithSceneName(string name)
    {
        //disables the rooms first
        foreach (GameObject room in rooms.Values) { room.SetActive(false); }
        foreach (GameObject item in items.Values) { item.SetActive(false); }

        //enables the room that needs to be enabled
        if (roomNames.TryGetValue(name, out string roomText))
        {
            roomName.text = roomText;
        }

        if (rooms.ContainsKey(roomText))
        {
            rooms[roomText].SetActive(true);
        }

        switch (roomText)
        {
            case "Reception":
                {
                    items["ReceptionItems"].SetActive(true);
                    break;
                }
            case "Office room":
                {
                    items["OfficeItems1"].SetActive(true);
                    break;
                }
            case "Office room 2":
                {
                    items["OfficeItems2"].SetActive(true);
                    break;
                }
            case "Office room 3":
                {
                    items["OfficeItems3"].SetActive(true);
                    break;
                }
            case "Office printer":
                {
                    items["OfficeItemsPrinter"].SetActive(true);
                    break;
                }
            case "Boss room":
                {
                    items["BossItems"].SetActive(true);
                    break;
                }
            case "Office pantry":
                {
                    items["OfficePantryItems"].SetActive(true);
                    break;
                }
            case "Office kitchen":
                {
                    items["OfficeKitchenItems"].SetActive(true);
                    break;
                }
        }
    }
}
