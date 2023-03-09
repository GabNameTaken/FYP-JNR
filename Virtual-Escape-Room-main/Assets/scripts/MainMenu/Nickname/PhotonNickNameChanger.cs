using Photon.Pun;

public class PhotonNickNameChanger
{
    private const int MINIMUM_NAME_LENGTH = 3;
    private const int MAXIMUM_NAME_LENGTH = 10;

    public void SetNameIfValid(string name)
    {
        if (NameIsValid(name))
            PhotonNetwork.NickName = name;
    }

    public bool NameIsValid(string name)
    {
        return (name.Length >= MINIMUM_NAME_LENGTH && name.Length <= MAXIMUM_NAME_LENGTH);
    }
}
