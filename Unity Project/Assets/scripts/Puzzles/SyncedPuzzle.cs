using Photon.Pun;

public class SyncedPuzzle : MonoBehaviourPun
{
    public delegate void OnSolvedPuzzle();
    public OnSolvedPuzzle onSolvedPuzzle;

    public void CallSyncSolvePuzzle()
    {
        photonView.RPC("SyncSolvePuzzle", RpcTarget.All);
    }

    [PunRPC]
    void SyncSolvePuzzle()
    {
        onSolvedPuzzle?.Invoke();
    }
}
