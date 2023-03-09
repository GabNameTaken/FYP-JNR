using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(menuName = "VideoBackground")]
public class VideoAssetFilePath : ScriptableObject
{
    readonly string folderPath = Application.streamingAssetsPath + "/Videos/";

    [SerializeField] string startVideoPath;
    [SerializeField] string loopVideoPath;
    [SerializeField] string endVideo;

    public string StartVideoURL { get => folderPath + startVideoPath; }
    public string LoopVideoURL { get => folderPath + loopVideoPath; }
    public string EndVideoURL { get => folderPath + endVideo; }
}