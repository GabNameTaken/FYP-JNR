using Photon.Pun;
public class SessionManager : MonoBehaviourPunCallbacks
{
    public delegate void OnJoinedSessionSuccess();
    public OnJoinedSessionSuccess onJoinedSessionSuccess;

    public delegate void OnJoinedSessionFail();
    public OnJoinedSessionFail onJoinedSessionFail;

    VoucherCodeChecker voucherCodeChecker;
    SessionInfo sessionInfo;

    private void Awake()
    {
        voucherCodeChecker = new();
    }

    public override void OnJoinedLobby()
    {
        onJoinedSessionSuccess?.Invoke();
    }


    public void SubmitVoucherCode(string voucherCode)
    {
        SessionInfo sessionInfo = voucherCodeChecker.GetSessionInfoFromAPI(voucherCode);

        if (sessionInfo != null)
        {
            StoreSessionInfo(sessionInfo);
            SessionCreator.JoinLobby(sessionInfo);
            
            // did this because you cant join lobby if you are in offline mode
            if (PhotonNetwork.OfflineMode)
                OnJoinedLobby();
        }
        else
        {
            onJoinedSessionFail?.Invoke();
        }
    }
    public void RejoinSession()
    {
        SessionCreator.JoinLobby(sessionInfo);
    }
    public int GetMaxPlayers()
    {
        return sessionInfo == null ? 0 : sessionInfo.MaxPlayers;
    }
    public SessionInfo GetSessionInfo()
    {
        return sessionInfo;
    }

    private void StoreSessionInfo(SessionInfo sessionInfo)
    {
        this.sessionInfo = sessionInfo;
    }
}
