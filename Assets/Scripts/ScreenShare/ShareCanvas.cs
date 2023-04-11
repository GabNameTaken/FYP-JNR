using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;


[System.Serializable]
public class CanvasData
{
    public float scale;
    public List<GraphicData> graphics;
}

// Custom class to represent the data of a Graphic
[System.Serializable]
public class GraphicData
{
    public string type;
    public Vector2 position;
    // Add any other properties you want to serialize here
}

public class ShareCanvas : MonoBehaviour
{
    public string SerializeCanvasToString(Canvas canvas)
    {
        // Serialize the canvas to a JSON string
        string json = JsonUtility.ToJson(canvas);

        // Return the serialized string
        return json;
    }

    public void SendCanvasToOtherPlayers(Canvas canvas, int viewId)
    {
        // Serialize the Canvas to a JSON string
        CanvasData canvasData = new CanvasData
        {
            scale = canvas.scaleFactor,
            graphics = new List<GraphicData>()
        };

        foreach (Graphic graphic in canvas.GetComponentsInChildren<Graphic>())
        {
            GraphicData graphicData = new GraphicData
            {
                type = graphic.GetType().ToString(),
                position = graphic.rectTransform.anchoredPosition
                // Add any other properties you want to serialize here
            };
            canvasData.graphics.Add(graphicData);
        }

        //string jsonString = JsonUtility.ToJson(canvasData);
        string jsonString = SerializeCanvasToString(canvas);

        // Create a Photon message and send it to other players
        object[] data = new object[] { jsonString, viewId };
        PhotonNetwork.RaiseEvent(RaiseEventManager.shareCanvas, data, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);
    }


    List<GameObject> gameObjects = new();
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            gameObjects.Add(transform.GetChild(i).gameObject);
        }
    }

    public void Share(List<Player> listOfPlayers)
    {
        int[] receivers = new int[listOfPlayers.Count];
        for (int i =0; i < listOfPlayers.Count; i++)
        {
            receivers[i] = listOfPlayers[i].ActorNumber;
        }
        if (CompareGameObjectList(gameObjects)) //Check for changes in the list of gameobjects under the canvas child
        {
            gameObjects.Clear();
            for (int i = 0; i < transform.childCount; i++)
            {
                gameObjects.Add(transform.GetChild(i).gameObject);
            }
            object[] content = new object[] { gameObjects };
            PhotonNetwork.RaiseEvent(RaiseEventManager.sendCanvas, content, new RaiseEventOptions { TargetActors = receivers }, SendOptions.SendReliable);
        }
    }

    bool CompareGameObjectList(List<GameObject> list)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            bool listActive = list[i].activeSelf;
            bool tempActive = transform.GetChild(i).gameObject.activeSelf;

            if (listActive != tempActive)
            {
                return true;
            }
        }

        return false;
    }

    void CallShareCanvas(Player targetPlayer)
    {
        PhotonView photonView;
        photonView = GetComponent<PhotonView>();

        photonView.RPC("OnShareCanvas", targetPlayer);
    }

    [PunRPC]
    void OnShareCanvas()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(gameObjects[i].activeSelf);
        }
    }
}
