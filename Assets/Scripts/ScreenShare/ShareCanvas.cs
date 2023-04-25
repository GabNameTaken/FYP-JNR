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
    public Dictionary<string, bool> activeStateOfCanvases = new();
    public List<GameObject> gameObjects;
    public List<Canvas> canvases;
    public List<Canvas> shareableCanvases;
    private void Start()
    {   
        canvases.AddRange(FindObjectsOfType<Canvas>(true));
        foreach (Canvas canvas in canvases)
        {
            if (canvas.gameObject.layer != LayerMask.NameToLayer("UI") && !shareableCanvases.Contains(canvas))
                shareableCanvases.Add(canvas);
        }
        //ResetActiveStateOfGameObjects();
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

    public Dictionary<string, bool> SaveActiveStateOfGameObjects()
    {
        ResetActiveStateOfGameObjects();
        return activeStateOfGameObjects;
    }

    public void SetActiveStateOfGameObjects(Dictionary<string, bool> activeStates)
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            GameObject child = gameObjects[i];
            child.SetActive(activeStates[child.name]);
        }
    }

    private void ResetActiveStateOfCanvases()
    {
        activeStateOfCanvases.Clear();
        foreach (Canvas canvas in shareableCanvases)
        {
            activeStateOfCanvases.Add(canvas.name, canvas.gameObject.activeSelf);
        }
    }

    public Dictionary<string, bool> SaveActiveStateOfCanvases()
    {
        ResetActiveStateOfCanvases();
        return activeStateOfCanvases;
    }

    public void SetActiveStateOfCanvases(Dictionary<string, bool> activeStates)
    {
        foreach (Canvas canvas in shareableCanvases)
        {
            canvas.gameObject.SetActive(activeStates[canvas.name]);
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
        if (CompareActiveStates(activeStateOfCanvases,"Canvas")) //Check for changes in the list of gameobjects under the canvas child
        {
            ResetActiveStateOfCanvases();
            Debug.Log("Raising event for sending canvas");
            object[] content = new object[] { activeStateOfCanvases };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendCanvas, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
        else
            Debug.Log("No canvas changes");
    }

    bool CompareActiveStates(Dictionary<string,bool> list, string source)   //check for child objects that had a change in their active
    {
        if (source == "Canvas")
        {
            foreach (Canvas canvas in shareableCanvases)
            {
                bool listActive = list[canvas.name];
                bool tempActive = canvas.gameObject.activeSelf;

                if (listActive != tempActive)
                {
                    Debug.Log("Change detected");
                    return true;
                }
            }
        }
        else if (source == "GameObject")
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
        }

        return false;
    }
}
