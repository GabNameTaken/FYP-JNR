using Byn.Awrtc;

public interface IConferenceVideoOutputHandler
{
    public void AddUser(ConnectionId id);
    public void RemoveUser(ConnectionId id);
    public void RemoveAllUsers();
    public void UpdateFrame(FrameUpdateEventArgs args);
}
