using Photon.Pun;
public class NickNameChanger
{
    public delegate void OnChangeNameCallBack();
    public static void ChangeNickName(string newName, OnChangeNameCallBack onSuccessCallBack, OnChangeNameCallBack onFailCallBack)
    {
        if (NickNameIsValid(newName))
        {
            PhotonNetwork.NickName = newName;
            onSuccessCallBack?.Invoke();
        }
        else
        {
            onFailCallBack?.Invoke();
        }
    }

    private static bool NickNameIsValid(string newName)
    {
        return !string.IsNullOrEmpty(newName);
    }
}
