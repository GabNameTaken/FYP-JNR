using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class RaiseEventManager : MonoBehaviour,IOnEventCallback
{
    public const byte sendCanvas = 1;
    public const byte sendGO = 2;
    public const byte sendText = 3;
    public const byte sendInput = 4;
    public void Start()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    public void OnDestroy()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public void OnEvent(EventData eventData)
    {
        if (eventData.Code == sendCanvas)
        {
            object[] data = (object[])eventData.CustomData;
            Dictionary<string,bool> activeStateOfCanvases = (Dictionary<string,bool>)data[0];
            ShareCanvas canvas = GameObject.Find("ShareScreenCanvas").GetComponent<ShareCanvas>();
            for (int i = 0; i < canvas.shareableCanvases.Count; i++)
            {
                canvas.shareableCanvases[i].gameObject.SetActive(activeStateOfCanvases[canvas.shareableCanvases[i].name]);
            }
            Debug.Log("Canvas sent");
        }
        else if (eventData.Code == sendGO)
        {
            object[] data = (object[])eventData.CustomData;
            Dictionary<string, bool> activeStateOfGameObjects = (Dictionary<string, bool>)data[0];
            ShareCanvas canvas = GameObject.Find("ShareScreenCanvas").GetComponent<ShareCanvas>();
            for (int i = 0; i < canvas.gameObjects.Count; i++)
            {
                canvas.gameObjects[i].SetActive(activeStateOfGameObjects[canvas.gameObjects[i].name]);
            }
            Debug.Log("GameObjects sent");
        }
        else if (eventData.Code == sendText)
        {
            object[] data = (object[])eventData.CustomData;
            Dictionary<int, string> textFields = (Dictionary<int, string>)data[0];
            ShareCanvas canvas = GameObject.Find("ShareScreenCanvas").GetComponent<ShareCanvas>();
            canvas.SetTextFields(textFields);
            Debug.Log("TextFields sent");
        }
        else if (eventData.Code == sendInput)
        {
            object[] data = (object[])eventData.CustomData;
            Dictionary<int, string> inputFields = (Dictionary<int, string>)data[0];
            ShareCanvas canvas = GameObject.Find("ShareScreenCanvas").GetComponent<ShareCanvas>();
            canvas.SetInputFields(inputFields);
            Debug.Log("InputFields sent");
        }
    }
}
