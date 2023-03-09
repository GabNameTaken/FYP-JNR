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
    public bool TryCreateRoom()
    {
        if (sessionSize.RoomsAreFull())
        {
            Debug.Log("Max number of players allowed to play reached");
            return false;
        }

        CreateRoom();
        return true;
    }

    private void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    private void CreateRoom()
    {
        Debug.Log("CREATE ROOM");
        RoomOptions roomOptions = new();
        roomOptions.MaxPlayers = (byte)roomSize;
        roomOptions.EmptyRoomTtl = 0;
        PhotonNetwork.CreateRoom("Room " + (PhotonNetwork.CountOfRooms + 1), roomOptions);
    }
}
