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
    public const byte sendScene = 2;
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
                Debug.Log(canvas.shareableCanvases[i].name + " : " + canvas.shareableCanvases[i].gameObject.activeSelf);
            }
            Debug.Log("Canvas sent");
        }
        else if (eventData.Code == sendScene)
        {
            object[] data = (object[])eventData.CustomData;
            Dictionary<string, bool> activeScenes = (Dictionary<string, bool>)data[0];
            Dictionary<string, bool> activeItems = (Dictionary<string, bool>)data[1];
            ShareScene scene = GameObject.Find("ShareScreenController").GetComponent<ShareScene>();
            for (int i = 0; i < scene.activeScenes.Count; i++)
            {
                scene.scenes.transform.GetChild(i).gameObject.SetActive(activeScenes[scene.scenes.transform.GetChild(i).name]);
            }
            for (int i = 0; i < scene.activeItems.Count; i++)
            {
                scene.items.transform.GetChild(i).gameObject.SetActive(activeItems[scene.items.transform.GetChild(i).name]);
            }
            Debug.Log("Scene sent");
        }
    }
}
