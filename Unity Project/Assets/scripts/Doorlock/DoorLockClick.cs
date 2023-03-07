public class DoorLockClick : InteractableObject
{
    LockedDoor roomDoor;

    private void Start()
    {
        roomDoor = transform.parent.GetComponent<LockedDoor>();
    }

    public string getGameObjectName() { return gameObject.name; }

    public override void OnClick()
    {
        roomDoor.AttemptOpenDoor();
    }
}
