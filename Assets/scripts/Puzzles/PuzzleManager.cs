using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(PhotonView))]
public class PuzzleManager : MonoSingletonTemplate<PuzzleManager>
{
    PhotonView photonView;
    Dictionary<SyncedPuzzle, bool> puzzleConpletionStatusCache;

    private void Awake()
    {
        InitializeSingleton(this, false);
        photonView = GetComponent<PhotonView>();
    }

    public void CallCachePuzzleCompletionStatus(SyncedPuzzle syncedPuzzle, bool status)
    {
        if (!puzzleConpletionStatusCache.ContainsKey(syncedPuzzle))
        {
            photonView.RPC("CachePuzzleCompletionStatus", RpcTarget.All, syncedPuzzle, status);
        }
    }
    [PunRPC]
    void CachePuzzleCompletionStatus(SyncedPuzzle syncedPuzzle, bool status)
    {
        puzzleConpletionStatusCache.Add(syncedPuzzle, status);
    }

    public bool GetPuzzleCompletionStatus(SyncedPuzzle syncedPuzzle)
    {
        puzzleConpletionStatusCache.TryGetValue(syncedPuzzle, out bool status);
        return status;
    }

    public void CallCompletePuzzle(SyncedPuzzle syncedPuzzle)
    {
        bool isPuzzleIncomplete = !GetPuzzleCompletionStatus(syncedPuzzle);
        if (isPuzzleIncomplete)
        {
            photonView.RPC("CompletePuzzle", RpcTarget.All, syncedPuzzle);
        }
    }
    void CompletePuzzle(SyncedPuzzle syncedPuzzle)
    {
        puzzleConpletionStatusCache[syncedPuzzle] = true;
    }
}
