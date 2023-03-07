using Photon.Pun;
using Photon.Realtime;

public class SessionCreator
{
    public static void JoinLobby(SessionInfo sessionInfo)
    {
        if (IsSessionInfoValid(sessionInfo))
        {
            TypedLobby typedLobby = new(sessionInfo.VoucherCode, LobbyType.Default);
            if (!PhotonNetwork.OfflineMode)
                PhotonNetwork.JoinLobby(typedLobby);
        }
    }

    private static bool IsSessionInfoValid(SessionInfo sessionInfo)
    {
        return !string.IsNullOrEmpty(sessionInfo.VoucherCode);
    }
}
