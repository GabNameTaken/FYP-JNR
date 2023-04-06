using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class QueuedVideoPlayerController : MonoBehaviour
{
    [SerializeField] RenderTexture renderTexture;
    [Tooltip("End videos earlier to account for the brief 'no video' frame(s). This was an issue last time, you probably dont need to use this now")]
    [SerializeField] double videoEndTimeMarginSeconds;
    // We create an object pool of video players to prepare other videos while one is playing
    [SerializeField] ObjectPooler<VideoPlayer> videoPlayerPool;

    public delegate void OnFinishedPlayingVideo(string url);
    public OnFinishedPlayingVideo onFinishedPlayingVideo;

    readonly Queue<KeyValuePair<string, VideoPlayer>> urlVideoPlayerQueue = new();

    VideoPlayer currentVideoPlayer;

    bool isCoroutineRunning;
    bool HaveVideoToPlay { get => urlVideoPlayerQueue.Count > 0; }
    bool IsNextVideoPrepared { get => urlVideoPlayerQueue.Peek().Value.isPrepared || !VideoURLIsValid(urlVideoPlayerQueue.Peek().Key); }

    public void QueueVideoURL(string url)
    {
        QueueVideoWithLoopOption(url, false);
    }

    public void QueueLoopedVideoURL(string url)
    {
        QueueVideoWithLoopOption(url, true);
    }

    private void QueueVideoWithLoopOption(string url, bool isLooping)
    {
        VideoPlayer videoPlayer = videoPlayerPool.FetchComponent();

        if (VideoURLIsValid(url))
        {
            videoPlayer.url = url;
            videoPlayer.isLooping = isLooping;
            videoPlayer.Prepare();
        }

        urlVideoPlayerQueue.Enqueue(new KeyValuePair<string, VideoPlayer>(url, videoPlayer));

        //Debug.Log("Queued Video: " + url);

        if (!isCoroutineRunning)
            StartCoroutine(VideoManagementCycle());
    }

    private bool VideoURLIsValid(string url)
    {
        return url.EndsWith(".mp4");
    }

    IEnumerator VideoManagementCycle()
    {
        isCoroutineRunning = true;
        //Debug.Log("Start Video Cycle Coroutine");

        while (HaveVideoToPlay)
        {
            KeyValuePair<string, VideoPlayer> urlVideoPlayerPair = urlVideoPlayerQueue.Dequeue();

            string url = urlVideoPlayerPair.Key;
            VideoPlayer videoPlayer = urlVideoPlayerPair.Value;

            //Debug.Log("1. Dequeue videoPlayer playing: " + url + " [prepared: " + videoPlayer.isPrepared + "]");

            if (VideoURLIsValid(url))
            {
                yield return new WaitUntil(() => videoPlayer.isPrepared);
                //Debug.Log("2a. Prepared Video: " + videoPlayer.url);

                PlayVideo(videoPlayer);
                //Debug.Log("3. Played Video. Frame: " + videoPlayer.frame + ". This shld be false: " + VideoHasEnded(videoPlayer) + ". URL[" + videoPlayer.url + "]");

                if (currentVideoPlayer)
                {
                    ReturnVideoPlayer(currentVideoPlayer);
                    //Debug.Log("3b. Returned Previous video player");
                }
                currentVideoPlayer = videoPlayer;


                if (videoPlayer.isLooping)
                    yield return new WaitUntil(() => HaveVideoToPlay && IsNextVideoPrepared);
                else
                    yield return new WaitUntil(() => VideoHasEnded(videoPlayer));

                //Debug.Log("4. Video Ended/Switching video");
            }
            else
            {
                //Debug.Log("2b. Video was invalid or empty");
            }

            onFinishedPlayingVideo?.Invoke(url);
        }

        isCoroutineRunning = false;
        //Debug.Log("End Video Cycle Coroutine");
    }
    private bool VideoHasEnded(VideoPlayer videoPlayer)
    {
        return (videoPlayer.frame > 0 && !videoPlayer.isPlaying);
    }

    private void PlayVideo(VideoPlayer videoPlayer)
    {
        videoPlayer.targetTexture = renderTexture;
        videoPlayer.frame = 0;
        videoPlayer.Play();
    }

    private void ReturnVideoPlayer(VideoPlayer videoPlayer)
    {
        videoPlayer.targetTexture = null;
        ObjectPooler<VideoPlayer>.ReturnGO(videoPlayer.gameObject);
    }
}
