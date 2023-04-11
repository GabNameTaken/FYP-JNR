using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class RaiseEventManager : MonoBehaviour,IOnEventCallback
{
    public const byte shareCanvas = 1;
    public const byte sendCanvas = 2;
    public void Start()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    public void OnDestroy()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public static void CopyCanvas(Canvas sourceCanvas, Canvas targetCanvas)
    {
        targetCanvas.renderMode = sourceCanvas.renderMode;
        targetCanvas.pixelPerfect = sourceCanvas.pixelPerfect;
        targetCanvas.worldCamera = sourceCanvas.worldCamera;
        targetCanvas.planeDistance = sourceCanvas.planeDistance;
        targetCanvas.sortingLayerID = sourceCanvas.sortingLayerID;
        targetCanvas.sortingOrder = sourceCanvas.sortingOrder;
        targetCanvas.targetDisplay = sourceCanvas.targetDisplay;
    }

    public void OnEvent(EventData eventData)
    {
        if (eventData.Code == shareCanvas)
        {
            object[] data = (object[])eventData.CustomData;
            // Deserialize the canvas data back into a canvas object
            string canvasDataStr = (string)data[0];
            CanvasData canvasData = JsonUtility.FromJson<CanvasData>(canvasDataStr);

            Debug.Log((string)data[0]);
            Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            canvas.scaleFactor = canvasData.scale;

            //foreach (GraphicData graphicData in canvasData.graphics)
            //{
            //    GameObject graphicObject = new GameObject(graphicData.type);
            //    graphicObject.AddComponent(System.Type.GetType(graphicData.type));
            //    Graphic graphic = graphicObject.GetComponent<Graphic>();
            //    graphic.rectTransform.anchoredPosition = graphicData.position;
            //    // Add any other properties you want to deserialize here
            //    graphic.transform.SetParent(canvas.transform);
            //}

            // Update the canvas on the receiving end
            int viewId = (int)data[1];
            GameObject canvasGO = PhotonView.Find(viewId).gameObject;
            CopyCanvas(canvas, canvasGO.GetComponent<Canvas>());
            Debug.Log("Canvas shared to " + viewId);
        }
        else if (eventData.Code == sendCanvas)
        {
            object[] data = (object[])eventData.CustomData;
            List<GameObject> listOfGameObjects = (List<GameObject>)data[0];
            GameObject canvasGO = GameObject.Find("Canvas");
            for (int i = 0; i < canvasGO.transform.childCount; i++)
            {
                canvasGO.transform.GetChild(i).gameObject.SetActive(listOfGameObjects[i].activeSelf);
            }
            Debug.Log("Canvas sent");
        }
    }
}
