public interface IVideoConferenceUIHandler
{
    public void JoinConference();
    public void LeaveConference();
    public void SetUsername(string username);
    public void SetRoomName(string roomName);
    public void ToggleMute(bool state);
    public void ToggleVideo(bool state);
}
