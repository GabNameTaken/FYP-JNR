using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using ExitGames.Client.Photon;
using Photon.Realtime;

public class EndingVideo : MonoBehaviour
{
    [SerializeField] VideoAssetFilePath videoAssetFilePath;
    [SerializeField] QueuedVideoPlayerController queuedVideoPlayerController;

    private void OnEnable()
    {
        queuedVideoPlayerController.QueueVideoURL(videoAssetFilePath.StartVideoURL);
        //queuedVideoPlayerController.QueueLoopedVideoURL(videoAssetFilePath.LoopVideoURL);
    }

    private void Update()
    {
        if (!queuedVideoPlayerController.VideoPlayState())
        {
            object[] content = new object[] { true };
            PhotonNetwork.RaiseEvent(RaiseEventManager.endGame, content, new RaiseEventOptions { Receivers = ReceiverGroup.All }, SendOptions.SendReliable);
        }
    }
}
