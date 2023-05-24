using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneNavigation : MonoBehaviour
{
    [SerializeField] GameObject[] rooms;
    [SerializeField] GameObject[] items;

    TMP_Text roomName;

    private void Start()
    {
        roomName = GameObject.Find("Canvas").transform.Find("RoomName").GetComponent<TMP_Text>();
    }
    public void ChangeSceneWithSceneName(string name)
    {
        //disables the rooms first
        foreach (GameObject room in rooms) { room.SetActive(false); }
        foreach (GameObject item in items) { item.SetActive(false); }

        //enables the room that needs to be enabled

        if (name == "Arrow_Office1")
        {
            roomName.text = "Office room";
            rooms[2].SetActive(true);
            items[1].SetActive(true);
        }
        else if (name == "Arrow_Office2")
        {
            roomName.text = "Office room 2";
            rooms[3].SetActive(true);
            items[2].SetActive(true);
        }
        else if (name == "Arrow_Office3")
        {
            roomName.text = "Office room 3";
            rooms[4].SetActive(true);
            items[3].SetActive(true);
        }
        else if (name == "Arrow_OfficePrinter")
        {
            roomName.text = "Office printer";
            rooms[5].SetActive(true);
            items[4].SetActive(true);
        }
        else if (name == "Arrow_OfficeMeetingRoom")
        {
            roomName.text = "Office meeting room";
            rooms[6].SetActive(true);
        }
        else if (name == "Arrow_OfficePantry1")
        {
            roomName.text = "Office pantry";
            rooms[7].SetActive(true);
            items[6].SetActive(true);
        }
        else if (name == "Arrow_OfficePantry")
        {
            roomName.text = "Office kitchen";
            rooms[8].SetActive(true);
            items[7].SetActive(true);
        }
        else if (name == "Arrow_BossRoom")
        {
            roomName.text = "Boss room";
            rooms[9].SetActive(true);
            items[5].SetActive(true);
        }
        else if (name == "Arrow_Reception")
        {
            roomName.text = "Reception";
            rooms[0].SetActive(true);
            items[0].SetActive(true);
        }
        else if (name == "Arrow_Lobby")
        {
            roomName.text = "Lift lobby";
            rooms[1].SetActive(true);
        }
    }
}
