using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "VideoBackground")]
public class VideoAssetFilePath : ScriptableObject
{
    readonly string folderPath = Application.streamingAssetsPath + "/Videos/";

    [Header("Put your videos in 'StreamingAssets/Videos'.")]
    [SerializeField] string startVideoPath;
    [SerializeField] string loopVideoPath;
    [SerializeField] string endVideoPath;

    public string StartVideoURL { get => folderPath + startVideoPath; }
    public string LoopVideoURL { get => folderPath + loopVideoPath; }
    public string EndVideoURL { get => folderPath + endVideoPath; }
}