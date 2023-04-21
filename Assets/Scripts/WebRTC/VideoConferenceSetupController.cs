using UnityEngine;
using Photon.Pun;
using System.Collections;
public class VideoConferenceSetupController : MonoBehaviourPunCallbacks
{
    [SerializeField] VideoConference videoConference;
    private IVideoConferenceUIHandler videoConferenceUIHandler;

    bool muteOnJoin = true;
    bool videoOnJoin;
    public bool MuteOnJoin { get => muteOnJoin; set => muteOnJoin = value; }
    public bool VideoOnJoin { get => videoOnJoin; set => videoOnJoin = value; }

    public delegate void SetupControllerEvent();
    public SetupControllerEvent onJoinedConference;
    public SetupControllerEvent onLeftConference;
    public SetupControllerEvent onJoinedRoom;
    public SetupControllerEvent onLeftRoom;

    private void Awake()
    {
        videoConferenceUIHandler = videoConference;
        DontDestroyOnLoad(this);
    }
    public override void OnEnable()
    {
        base.OnEnable();

        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }

        videoConference.onJoinedConference += OnJoinedConference;
        videoConference.onLeftConference += OnLeftConference;
    }

    public override void OnDisable()
    {
        base.OnDisable();

        videoConference.onJoinedConference -= OnJoinedConference;
        videoConference.onLeftConference -= OnLeftConference;
    }

    private void OnJoinedConference()
    {
        onJoinedConference?.Invoke();
    }
    private void OnLeftConference()
    {
        onLeftConference?.Invoke();
    }

    public override void OnJoinedRoom()
    {
        SetupFields();
        onJoinedRoom?.Invoke();
    }
    public override void OnLeftRoom()
    {
        onLeftRoom?.Invoke();
    }

    private void SetupFields()
    {
        videoConference.SetUsername(PhotonNetwork.LocalPlayer.UserId);
        videoConference.SetRoomName(PhotonNetwork.CurrentRoom.Name);
    }

    public void JoinConference()
    {
        videoConference.ToggleMute(MuteOnJoin);
        videoConference.ToggleVideo(VideoOnJoin);
        videoConferenceUIHandler.JoinConference();
        StartCoroutine(WaitForJoin());
    }

    IEnumerator WaitForJoin()
    {
        yield return new WaitForSeconds(1.0f);
        videoConference.ToggleMute(MuteOnJoin);
        Debug.Log(MuteOnJoin);
    }

    public void LeaveConference()
    {
        videoConferenceUIHandler.LeaveConference();
    }

    public void MuteInCall(bool state)
    {
        videoConferenceUIHandler.ToggleMute(state);
    }

    public void ToggleVideoInCall(bool state)
    {
        videoConferenceUIHandler.ToggleVideo(state);
    }
}
