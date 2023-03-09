using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoBackgroundPage : MonoBehaviour
{
    [Header("Video Background")]
    [SerializeField] VideoAssetFilePath videoAssetFilePath;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject content;
    [Space]
    private bool isTransitioning = false;
    public bool IsTransitioning { get => isTransitioning; }

    public IEnumerator TransitionIn()
    {
        isTransitioning = true;

        videoPlayer.isLooping = false;
        PlayVideo(videoAssetFilePath.StartVideoURL);

        //yield return new WaitForSeconds(VideoLengthInSeconds());
        yield return new WaitUntil(() => VideoHasEnded());

        videoPlayer.isLooping = true;
        PlayVideo(videoAssetFilePath.LoopVideoURL);

        SetContentActive(true);

        isTransitioning = false;
    }

    public IEnumerator TransitionOut()
    {
        isTransitioning = true;

        SetContentActive(false);

        videoPlayer.isLooping = false;
        PlayVideo(videoAssetFilePath.EndVideoURL);

        //yield return new WaitForSeconds(VideoLengthInSeconds());
        yield return new WaitUntil(() => VideoHasEnded());

        isTransitioning = false;
    }

    private void PlayVideo(string url)
    {
        if (VideoURLIsValid(url))
        {
            videoPlayer.url = url;
            videoPlayer.Play();
        }
    }

    private float VideoLengthInSeconds()
    {
        return (float)videoPlayer.length * (1 / videoPlayer.playbackSpeed);
    }
    private bool VideoHasEnded()
    {
        return (!videoPlayer.isPlaying && videoPlayer.frame > 0) 
            || !VideoURLIsValid(videoPlayer.url);
    }

    private void SetContentActive(bool active)
    {
        if (content)
            content.SetActive(active);
    }

    private bool VideoURLIsValid(string url)
    {
        return url.EndsWith(".mp4");
    }
}
