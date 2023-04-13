using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class RaiseEventManager : MonoBehaviour,IOnEventCallback
{
    public const byte sendCanvas = 1;
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
            Dictionary<string,bool> activeStateOfGameObjects = (Dictionary<string,bool>)data[0];
            ShareCanvas canvas = GameObject.Find("NetworkCanvasController").GetComponent<ShareCanvas>();
            for (int i = 0; i < canvas.gameObjects.Count; i++)
            {
                canvas.gameObjects[i].SetActive(activeStateOfGameObjects[canvas.gameObjects[i].name]);
            }
            Debug.Log("Canvas sent");
        }
    }
}
