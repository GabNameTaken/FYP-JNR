using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;

public class ShareCanvas : MonoBehaviour
{
    public Dictionary<string,bool> activeStateOfGameObjects = new();
    public List<GameObject> gameObjects;
    private void Start()
    {
        ResetActiveStateOfGameObjects();
    }

    private void ResetActiveStateOfGameObjects()
    {
        activeStateOfGameObjects.Clear();
        for (int i = 0; i < gameObjects.Count; i++)
        {
            GameObject child = gameObjects[i];
            activeStateOfGameObjects.Add(child.name, child.activeSelf);
            //Debug.Log(activeStateOfGameObjects);
        }
    }

    public Dictionary<string,bool> SaveActiveStateOfGameObjects()
    {
        ResetActiveStateOfGameObjects();
        return activeStateOfGameObjects;
    }

    public void SetActiveStateOfGameObjects(Dictionary<string,bool> activeStates)
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            GameObject child = gameObjects[i];
            child.SetActive(activeStates[child.name]);
        }
    }

    public void Share(List<Player> listOfViewers)
    {
        int[] receivers = new int[listOfViewers.Count];
        for (int i =0; i < listOfViewers.Count; i++)
        {
            receivers[i] = listOfViewers[i].ActorNumber;
            Debug.Log("Sharing to " + receivers[i]);
        }
        if (CompareActiveStates(activeStateOfGameObjects)) //Check for changes in the list of gameobjects under the canvas child
        {
            ResetActiveStateOfGameObjects();
            Debug.Log("Raising event for sending canvas");
            object[] content = new object[] { activeStateOfGameObjects };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendCanvas, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
        else
            Debug.Log("No canvas changes");
    }

    bool CompareActiveStates(Dictionary<string,bool> list)   //check for child objects that had a change in their active
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            bool listActive = list[gameObjects[i].name];
            bool tempActive = gameObjects[i].activeSelf;

            if (listActive != tempActive)
            {
                Debug.Log("Change detected");
                return true;
            }
        }

        return false;
    }
}
