using UnityEngine;
using Photon.Pun;
public class ConnectionPageUI : MonoBehaviourPunCallbacks
{
    [SerializeField] NavigationPage navigationPage;
    [SerializeField] VideoBackgroundPage nextPage;

    public override void OnConnectedToMaster()
    {
        PushPage(nextPage);
    }

    public void PushPage(VideoBackgroundPage videoBackgroundPage)
    {
        navigationPage.PushPage(videoBackgroundPage);
    }
}