using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoomUI : MonoBehaviour
{
    public void OnClick_CreateRoom()
    {
        CreateJoinRoomManager.instance.TryCreateRoom();
    }
}
