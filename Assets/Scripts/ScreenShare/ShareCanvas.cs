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
    private Dictionary<string,bool> activeStateOfGameObjects = new();
    private Dictionary<string, bool> activeStateOfCanvases = new();
    private Dictionary<int, string> inputTexts = new();
    private Dictionary<int, string> textFields = new();

    public List<GameObject> gameObjects;
    public List<Canvas> shareableCanvases;
    public List<TMP_InputField> inputFields;
    public List<TMP_Text> puzzleTextFieldsList;

    [SerializeField] private List<Canvas> canvases;
    [SerializeField] private List<TMP_Text> textList;
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
        textList.AddRange(FindObjectsOfType<TMP_Text>(true));
        foreach (TMP_Text field in textList)
        {
            if (field.gameObject.layer == LayerMask.NameToLayer("PuzzleUI"))
                puzzleTextFieldsList.Add(field);
        }

        ResetActiveStateOfCanvases();
        ResetActiveStateOfGameObjects();
        ResetInputFields();
        ResetTextFields();
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

    private void ResetTextFields()
    {
        textFields.Clear();
        for (int i = 0; i < puzzleTextFieldsList.Count;i++)
        {
            textFields.Add(i, puzzleTextFieldsList[i].text);
        }
    }

    public Dictionary<int,string> SaveTextFields()
    {
        ResetTextFields();
        return textFields;
    }

    public void SetTextFields(Dictionary<int,string> texts)
    {
        textFields = texts;
        for (int i = 0; i < puzzleTextFieldsList.Count; i++)
        {
            puzzleTextFieldsList[i].text = texts[i];
        }
    }

    public void UpdateShare(List<Player> listOfViewers)
    {
        int[] receivers = new int[listOfViewers.Count];
        for (int i =0; i < listOfViewers.Count; i++)
        {
            receivers[i] = listOfViewers[i].ActorNumber;
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
        if (CompareTMPFields(inputTexts, "Inputs"))
        {
            ResetInputFields();
            Debug.Log("Raising event for sending inputs");
            object[] content = new object[] { inputTexts };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendInput, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
        if (CompareTMPFields(textFields, "Texts"))
        {
            ResetTextFields();
            Debug.Log("Raising event for sending texts");
            object[] content = new object[] { textFields };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendText, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
    }

    public void Share(Player target)
    {
        int[] receiver = new int[1];
        receiver[0] = target.ActorNumber;

        ResetActiveStateOfCanvases();
        Debug.Log("Raising event for sending canvas");
        object[] content = new object[] { activeStateOfCanvases };
        PhotonNetwork.RaiseEvent(RaiseEventManager.sendCanvas, content, new RaiseEventOptions { TargetActors = receiver }, SendOptions.SendReliable);

        ResetActiveStateOfGameObjects();
        Debug.Log("Raising event for sending gameobjects");
        content = new object[] { activeStateOfGameObjects };
        PhotonNetwork.RaiseEvent(RaiseEventManager.sendGO, content, new RaiseEventOptions { TargetActors = receiver }, SendOptions.SendReliable);

        ResetInputFields();
        Debug.Log("Raising event for sending inputs");
        content = new object[] { inputTexts };
        PhotonNetwork.RaiseEvent(RaiseEventManager.sendInput, content, new RaiseEventOptions { TargetActors = receiver }, SendOptions.SendReliable);

        ResetTextFields();
        Debug.Log("Raising event for sending texts");
        content = new object[] { textFields };
        PhotonNetwork.RaiseEvent(RaiseEventManager.sendText, content, new RaiseEventOptions { TargetActors = receiver }, SendOptions.SendReliable);
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

    bool CompareTMPFields(Dictionary<int,string> fields, string source)
    {
        switch (source)
        {
            case "Inputs":
                {
                    for (int i = 0; i < inputFields.Count; i++)
                    {
                        string input = fields[i];
                        string tempInput = inputFields[i].text;

                        if (input != tempInput)
                        {
                            Debug.Log("InputFields change detected");
                            return true;
                        }
                    }
                    break;
                }
            case "Texts":
                {
                    for (int i = 0; i < puzzleTextFieldsList.Count; i++)
                    {
                        string text = fields[i];
                        string tempText = puzzleTextFieldsList[i].text;

                        if (text != tempText)
                        {
                            Debug.Log("TextFields change detected");
                            return true;
                        }
                    }
                    break;
                }
        }
        return false;
    }
}
