using UnityEngine;
using TMPro;
using Photon.Realtime;

public class RoomScrollItem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI roomName;
    [SerializeField] TextMeshProUGUI roomCapacity;
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        roomName.text = roomInfo.Name;
        roomCapacity.text = roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers;
    }

    public void OnClick_JoinRoom()
    {
        CreateJoinRoomManager.instance.TryJoinRoom(roomName.text);
    }
}
