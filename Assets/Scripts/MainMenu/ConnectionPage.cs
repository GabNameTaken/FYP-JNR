using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Photon.Pun;

public class ConnectionPage : MonoBehaviourPunCallbacks
{
    readonly string folderPath = Application.streamingAssetsPath + "/Videos/";

    [Header("Put your videos in 'StreamingAssets/Videos'.")]
    [SerializeField] string loopVideoPath;
    [SerializeField] GameObject nextPage;
    public string LoopVideoURL { get => folderPath + loopVideoPath; }

    private void Awake()
    {
        gameObject.GetComponent<VideoPlayer>().url = LoopVideoURL;
    }

    public override void OnConnectedToMaster()
    {
        nextPage.SetActive(true);
        gameObject.SetActive(false);
    }
}
