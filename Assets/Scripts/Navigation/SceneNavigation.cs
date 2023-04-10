using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNavigation : MonoBehaviour
{
    // ARRAY OF ROOMS, KEEP ADDING TO THE BACK
    // 0 : reception room
    // 1 : office entrance
    // 2 : office left
    // 3 : office mid
    // 4 : office right 
    // 5 : boss room
    // 6 : lift lobby
    [SerializeField] GameObject[] rooms;

    private GameObject playercam;

    // ARRAY OF ROOM ITEMS, KEEP ADDING TO THE BACK
    // 0 : reception room items
    // 1 : office entrance items
    // 2 : office middle items
    // 3 : office rear items
    // 4 : office printer items
    // 5 : boss room
    [SerializeField] GameObject[] items;

    public void ChangeSceneWithSceneName(string name)
    {
        //disables the rooms first
        foreach (GameObject room in rooms) { room.SetActive(false); }
        foreach (GameObject item in items) { item.SetActive(false); }

        //enables the room that needs to be enabled

        if (name == "Arrow_Office1")
        {
            Debug.Log("Office room 1");
            playercam = GameObject.FindGameObjectWithTag("MainCamera");
            rooms[2].SetActive(true);
            items[1].SetActive(true);
            playercam.GetComponent<CCameraControls>().Office1Cam();
        }
        else if (name == "Arrow_Office2")
        {
            Debug.Log("Office room 2");
            rooms[3].SetActive(true);
            items[2].SetActive(true);
        }
        else if (name == "Arrow_Office3")
        {
            Debug.Log("Office room 3");
            rooms[4].SetActive(true);
            items[3].SetActive(true);
        }
        else if (name == "Arrow_OfficePrinter")
        {
            Debug.Log("Office Printer");
            rooms[5].SetActive(true);
            items[4].SetActive(true);
        }
        else if (name == "Arrow_OfficeMeetingRoom")
        {
            Debug.Log("Office room right");
            rooms[6].SetActive(true);
        }
        else if (name == "Arrow_OfficePantry")
        {
            Debug.Log("Office room right");
            rooms[8].SetActive(true);
        }
        else if (name == "Arrow_BossRoom")
        {
            playercam = GameObject.FindGameObjectWithTag("MainCamera");
            Debug.Log("Office room right");
            rooms[9].SetActive(true);
            items[5].SetActive(true);
            playercam.GetComponent<CCameraControls>().BossCam();
        }
        else if (name == "Arrow_Reception")
        {
            playercam = GameObject.FindGameObjectWithTag("MainCamera");
            Debug.Log("reception");
            rooms[0].SetActive(true);
            items[0].SetActive(true);
            playercam.GetComponent<CCameraControls>().ReceptionCam();
        }
        else if (name == "Arrow_Lobby")
        {
            playercam = GameObject.FindGameObjectWithTag("MainCamera");
            Debug.Log("Lift Lobby");
            rooms[1].SetActive(true);
            playercam.GetComponent<CCameraControls>().Office1Cam();
        }
    }
}