using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks 
{
    #region VARIABLES
    [SerializeField] bool useOfflineModeOnStart;
    [SerializeField] bool useOfflineModeOnDisconnect;
    #endregion

    //Initialise variables when Start is called
    void Start()
    {
        if (useOfflineModeOnStart)
            UseOfflineConnection();
        else
            ConnectToPhotonNetwork();
    }

    private static void ConnectToPhotonNetwork()
    {
        Debug.Log("Connecting to server...");
        PhotonNetwork.GameVersion = "0.0.2"; //locks users to the game version
        PhotonNetwork.ConnectUsingSettings(); //connect to photon master server
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private static void UseOfflineConnection()
    {
        Debug.Log("Using offline mode");
        PhotonNetwork.OfflineMode = true;
    }

    #region PHOTON_CALLBACKS

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to " + PhotonNetwork.CloudRegion + " server.");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from server: " + cause.ToString());
        if (useOfflineModeOnDisconnect)
            UseOfflineConnection();
        else
            ConnectToPhotonNetwork();
    }

    #endregion
}
