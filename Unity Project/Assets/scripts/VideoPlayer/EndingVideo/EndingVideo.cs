using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingVideo : MonoBehaviour
{
    [SerializeField] VideoAssetFilePath videoAssetFilePath;
    [SerializeField] QueuedVideoPlayerController queuedVideoPlayerController;
    private void OnEnable()
    {
        queuedVideoPlayerController.QueueVideoURL(videoAssetFilePath.StartVideoURL);
        queuedVideoPlayerController.QueueLoopedVideoURL(videoAssetFilePath.LoopVideoURL);
    }
}
