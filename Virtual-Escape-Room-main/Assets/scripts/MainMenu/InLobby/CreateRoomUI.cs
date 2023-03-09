using UnityEngine;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField] ModalWindow modalWindow;
    public void OnClick_CreateRoom()
    {
        modalWindow.InitialiseWindow();
        modalWindow.SetHeaderText("Create a room name:");
        modalWindow.SetInputFeild("Room name", 10);
        modalWindow.SetButton("Cancel", null);
        modalWindow.SetButton("Create", () => TryCreateRoom());
    }

    private void TryCreateRoom()
    {
        CreateJoinRoomManager.instance.TryCreateRoom(modalWindow.GetInputFieldValue());
    }
}
