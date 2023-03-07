using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class CreateJoinRoomManager : MonoSingletonTemplate<CreateJoinRoomManager>
{
    [SerializeField] SessionSize sessionSize;
    [SerializeField] int roomSize;

    private void Awake()
    {
        InitializeSingleton(this, false);
    }

    public bool TryJoinRoom(string roomName)
    {
        if (sessionSize.RoomsAreFull())
        {
            Debug.Log("Max number of players allowed to play reached");
            return false;
        }

        JoinRoom(roomName);
        return true;
    }
    public bool TryCreateRoom(string roomName)
    {
        if (sessionSize.RoomsAreFull())
        {
            Debug.Log("Max number of players allowed to play reached");
            return false;
        }

        CreateRoom(roomName);
        return true;
    }

    private void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    private void CreateRoom(string roomName)
    {
        Debug.Log("CREATE ROOM");
        RoomOptions roomOptions = new();
        roomOptions.MaxPlayers = (byte)roomSize;
        roomOptions.EmptyRoomTtl = 0;
        roomOptions.CustomRoomPropertiesForLobby = new string[1];
        roomOptions.CustomRoomPropertiesForLobby[0] = PlayerListEntries.PLAYER_LIST;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }
}
