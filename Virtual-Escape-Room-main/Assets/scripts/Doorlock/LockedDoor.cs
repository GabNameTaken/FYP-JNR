using Photon.Pun;
using UnityEngine;

public class LockedDoor : MonoBehaviourPun, ILockedDoor
{
    [SerializeField] GameObject receptionLock;
    [SerializeField] GameObject receptionArrow;

    bool isLocked = true;

    public void AttemptOpenDoor()
    {
        if (isLocked)
        {
            receptionLock.SetActive(true);
        }
    }

    public void UnlockDoor()
    {
        photonView.RPC("OpenDoorRPC", RpcTarget.All);
    }

    [PunRPC]
    void OpenDoorRPC()
    {
        receptionArrow.SetActive(true);
        isLocked = false;
    }
}
