using Photon.Pun;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class LevelLoader : MonoBehaviourPunCallbacks
{
    private const string GAME_STARTED = "GameStarted";
    public void StartGame()
    {
        SetGameStartedProperty(true);
    }

    public override void OnCreatedRoom()
    {
        SetGameStartedProperty(false);
    }
    public override void OnJoinedRoom()
    {
        LoadGameIfStarted(PhotonNetwork.CurrentRoom.CustomProperties);
    }
    public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
    {
        LoadGameIfStarted(propertiesThatChanged);
    }

    private void SetGameStartedProperty(bool value)
    {
        Hashtable initialProps = new Hashtable() { { GAME_STARTED, value } };
        PhotonNetwork.CurrentRoom.SetCustomProperties(initialProps);
    }
    private void LoadGameIfStarted(Hashtable roomProperties)
    {
        roomProperties.TryGetValue(GAME_STARTED, out object gameStartedProperty);

        bool started = gameStartedProperty == null ? false : (bool)gameStartedProperty;

        if (started)
        {
            //SceneLoader.LoadGameScenes();
            PhotonNetwork.LoadLevel((int)SceneLoader.SceneBuildIndexes.gameScene);
        }
    }
}