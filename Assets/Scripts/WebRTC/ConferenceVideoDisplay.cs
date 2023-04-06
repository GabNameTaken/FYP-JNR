using Byn.Awrtc;
using Byn.Awrtc.Unity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConferenceVideoDisplay : MonoBehaviour, IConferenceVideoOutputHandler
{
    [SerializeField] ObjectPooler<RawImage> videoDisplayObjectPool;
    [SerializeField] Texture noImgTexture;
    private class VideoData
    {
        public GameObject uiObject;
        public Texture2D texture;
        public RawImage image;

    }
    private readonly Dictionary<ConnectionId, VideoData> videoUiElements = new();

    public void AddUser(ConnectionId id)
    {
        VideoData vd = new VideoData();
        KeyValuePair<GameObject, RawImage> videoGOandRawImage = videoDisplayObjectPool.FetchInstance();
        vd.uiObject = videoGOandRawImage.Key;
        vd.image = videoGOandRawImage.Value;
        vd.image.texture = noImgTexture;
        videoUiElements[id] = vd;
    }
    public void RemoveUser(ConnectionId id)
    {
        if (videoUiElements.TryGetValue(id, out VideoData data))
        {
            ObjectPooler<RawImage>.ReturnGO(data.uiObject);
            videoUiElements.Remove(id);
        }
    }
    public void RemoveAllUsers()
    {
        foreach (var IDandVideoData in videoUiElements)
        {
            ObjectPooler<RawImage>.ReturnGO(IDandVideoData.Value.uiObject);
        }
        videoUiElements.Clear();
    }
    public void UpdateFrame(FrameUpdateEventArgs args)
    {
        if (videoUiElements.ContainsKey(args.ConnectionId))
        {
            VideoData videoData = videoUiElements[args.ConnectionId];
            //make sure not to overwrite / destroy our texture for missing image data
            if (videoData.image.texture == noImgTexture)
                videoData.image.texture = null;
            bool mirror = args.IsRemote == false;
            //converts the frame data to a texture and sets it to the raw image
            UnityMediaHelper.UpdateRawImageTransform(videoData.image, args.Frame, mirror);
            videoData.texture = videoData.image.texture as Texture2D;
        }
    }
}
