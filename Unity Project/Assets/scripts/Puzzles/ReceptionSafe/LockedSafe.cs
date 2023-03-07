using Photon.Pun;
using UnityEngine;

public class LockedSafe : MonoBehaviourPun
{
    [SerializeField] GameObject safelock;
    [SerializeField] GameObject receptionArrow;

    public void UnlockDoor()
    {
        photonView.RPC("OpenDoorRPC", RpcTarget.All);
    }

    [PunRPC]
    void OpenDoorRPC()
    {
        receptionArrow.SetActive(true);
    }
}
