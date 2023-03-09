using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;
public class PhotonConnectedEvent : MonoBehaviourPunCallbacks
{
    [SerializeField] UnityEvent onConnectedToMaster;

    public override void OnConnectedToMaster()
    {
        onConnectedToMaster?.Invoke();
    }
}
