using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;
using TMPro;

public class ShareCanvas : MonoBehaviour
{
    public Dictionary<string,bool> activeStateOfGameObjects = new();
    public Dictionary<string, bool> activeStateOfCanvases = new();
    public Dictionary<int, string> inputTexts = new();

    public List<GameObject> gameObjects;
    public List<Canvas> shareableCanvases;
    public List<TMP_InputField> inputFields;

    [SerializeField] private List<Canvas> canvases;
    private GameObject scenes;
    private GameObject itemHolder;
    private void Start()
    {
        scenes = GameObject.Find("Scene");
        itemHolder = GameObject.Find("ItemHolder");

        foreach (Transform scene in scenes.transform)
        {
            gameObjects.Add(scene.gameObject);
        }
        foreach (Transform item in itemHolder.transform)
        {
            gameObjects.Add(item.gameObject);
        }

        canvases.AddRange(FindObjectsOfType<Canvas>(true));
        foreach (Canvas canvas in canvases)
        {
            if (canvas.gameObject.layer != LayerMask.NameToLayer("UI") && !shareableCanvases.Contains(canvas))
                shareableCanvases.Add(canvas);
        }
        inputFields.AddRange(FindObjectsOfType<TMP_InputField>(true));

        ResetActiveStateOfCanvases();
        ResetActiveStateOfGameObjects();
        ResetInputFields();
    }

    private void ResetActiveStateOfGameObjects()
    {
        activeStateOfGameObjects.Clear();
        for (int i = 0; i < gameObjects.Count; i++)
        {
            GameObject child = gameObjects[i];
            activeStateOfGameObjects.Add(child.name, child.activeSelf);
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

    private void ResetInputFields()
    {
        inputTexts.Clear();
        for (int i = 0; i < inputFields.Count; i++)
        {
            inputTexts.Add(i, inputFields[i].text);
        }
    }

    public Dictionary<int, string> SaveInputFields()
    {
        ResetInputFields();
        return inputTexts;
    }

    public void SetInputFields(Dictionary<int, string> inputs)
    {
        inputTexts = inputs;
        for (int i = 0; i < inputFields.Count; i++)
        {
            inputFields[i].text = inputs[i];
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
        if (CompareActiveStates(activeStateOfGameObjects, "GameObject"))
        {
            ResetActiveStateOfGameObjects();
            Debug.Log("Raising event for sending gameobjects");
            object[] content = new object[] { activeStateOfGameObjects };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendGO, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
        if (CompareInputFields(inputTexts))
        {
            ResetInputFields();
            Debug.Log("Raising event for sending inputs");
            object[] content = new object[] { inputTexts };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendInput, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
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

    bool CompareInputFields(Dictionary<int,string> inputFieldsAndInputs)
    {
        for (int i = 0; i < inputFields.Count; i++)
        {
            string input = inputFieldsAndInputs[i];
            string tempInput = inputFields[i].text;

            if (input != tempInput)
            {
                Debug.Log("InputFields change detected");
                return true;
            }
        }
        return false;
    }
}
