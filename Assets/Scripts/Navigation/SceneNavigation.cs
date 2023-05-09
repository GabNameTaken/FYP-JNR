using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNavigation : MonoBehaviour
{
    [SerializeField] private Dictionary<string,GameObject> items = new();
    [SerializeField] private Dictionary<string,GameObject> scenes = new();

    private void Start()
    {
        GameObject scene = GameObject.Find("Scene");
        for (byte i = 0; i < scene.transform.childCount; i++)
        {
            scenes.Add(scene.transform.GetChild(i).name, scene.transform.GetChild(i).gameObject);
        }

        GameObject itemHolder = GameObject.Find("ItemHolder");
        for (byte i = 0; i < itemHolder.transform.childCount; i++)
        {
            items.Add(itemHolder.transform.GetChild(i).name, itemHolder.transform.GetChild(i).gameObject);
        }
    }
    public void ChangeSceneWithSceneName(string name)
    {
        //disables the scenes first
        foreach (GameObject room in scenes.Values) { room.SetActive(false); }
        foreach (GameObject item in items.Values) { item.SetActive(false); }

        //enables the room that needs to be enabled

        if (name == "Arrow_Office1")
        {
            Debug.Log("Office room 1");
            scenes["Office1"].SetActive(true);
            items["OfficeItems1"].SetActive(true);
        }
        else if (name == "Arrow_Office2")
        {
            Debug.Log("Office room 2");
            scenes["Office2"].SetActive(true);
            items["OfficeItems2"].SetActive(true);
        }
        else if (name == "Arrow_Office3")
        {
            Debug.Log("Office room 3");
            scenes["Office3"].SetActive(true);
            items["OfficeItems3"].SetActive(true);
        }
        else if (name == "Arrow_OfficePrinter")
        {
            Debug.Log("Office Printer");
            scenes["OfficePrinter"].SetActive(true);
            items["OfficeItemsPrinter"].SetActive(true);
        }
        else if (name == "Arrow_OfficeMeetingRoom")
        {
            Debug.Log("Office room right");
            scenes["OfficeMeetingRoom"].SetActive(true);
        }
        else if (name == "Arrow_OfficePantry1")
        {
            Debug.Log("Office pantry1");
            scenes["OfficePantry (1)"].SetActive(true);
            items["OfficePantry1Items"].SetActive(true);
        }
        else if (name == "Arrow_OfficePantry")
        {
            Debug.Log("Office room right");
            scenes["OfficePantry"].SetActive(true);
            items["OfficePantryItems"].SetActive(true);
        }
        else if (name == "Arrow_BossRoom")
        {
            Debug.Log("Office room right");
            scenes["BossRoom"].SetActive(true);
            items["BossItems"].SetActive(true);
        }
        else if (name == "Arrow_Reception")
        {
            Debug.Log("reception");
            scenes["Reception"].SetActive(true);
            items["ReceptionItems"].SetActive(true);
        }
        else if (name == "Arrow_Lobby")
        {
            Debug.Log("Lift Lobby");
            scenes["LiftLobby"].SetActive(true);
        }
        else if (name == "Arrow_Floor1Lobby")
        {
            scenes["Lobby"].SetActive(true);
        }
        else if (name == "Arrow_Lift")
        {
            scenes["Lift"].SetActive(true);
        }
        else if (name == "Arrow_EntranceLobby1")
        {
            scenes["EntranceLobby1"].SetActive(true);
        }
        else if (name == "Arrow_EntranceLobby2")
        {
            scenes["EntranceLobby2"].SetActive(true);
        }
        else if (name == "Arrow_EntranceLobby3")
        {
            scenes["EntranceLobby3"].SetActive(true);
        }
        else if (name == "Arrow_LoungeHall")
        {
            scenes["LoungeHall"].SetActive(true);
        }
        else if (name == "Arrow_Lounge")
        {
            scenes["Lounge"].SetActive(true);
        }
        else if (name == "Arrow_LoungeKitchen")
        {
            scenes["LoungeKitchen"].SetActive(true);
        }
        else if (name == "Arrow_LobbyMeetingRoom1")
        {
            scenes["LobbyMeetingRoom1"].SetActive(true);
        }
        else if (name == "Arrow_LobbyMeetingRoom2")
        {
            scenes["LobbyMeetingRoom2"].SetActive(true);
        }
    }
}
