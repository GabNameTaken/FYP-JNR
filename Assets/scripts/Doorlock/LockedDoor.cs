using Photon.Pun;
using UnityEngine;

public class LockedDoor : MonoBehaviourPun, ILockedDoor
{
    [SerializeField] GameObject receptionLock, roomObjects;
    [SerializeField] GameObject receptionArrow;
    [SerializeField] GameObject[] otherGOs;

    bool isLocked = true;

    public void AttemptOpenDoor()
    {
        if (isLocked)
        {
            receptionLock.SetActive(true);
            roomObjects.SetActive(false);
            for (int i = 0; i < otherGOs.Length; i++)
            {
                otherGOs[i].SetActive(false);
            }
        }
    }

    public void UnlockDoor()
    {
        receptionLock.SetActive(false);
        roomObjects.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
        photonView.RPC("OpenDoorRPC", RpcTarget.All);
    }

    [PunRPC]
    void OpenDoorRPC()
    {
        receptionArrow.SetActive(true);
        isLocked = false;
    }

    public void Close()
    {
        receptionLock.SetActive(false);
        roomObjects.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
