using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class SceneGameManager : MonoBehaviourPunCallbacks
{
    private PhotonView photonView;
    private GameObject thisPlayer;
    [SerializeField] GameObject previewObject;
    [SerializeField] GameObject GameOverCanvas;
    [SerializeField] GameObject WinScreenCanvas;
    [SerializeField] GameTimer timer;

    public bool winState;
    public override void OnEnable()
    {
        base.OnEnable();

        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }
    }
    public override void OnJoinedRoom()
    {
        StartGame();
    }

    private void StartGame()
    {
        thisPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, 0), Quaternion.identity);
        photonView = thisPlayer.GetPhotonView();
    }

    public PhotonView GetPlayerPhotonView()
    {
        return photonView;
    }

    public void EndGame(bool win)
    {
        winState = win;

        if (!winState)
        {
            GameOverCanvas.GetComponent<CanvasToggle>().SetCanvasToActive();
        }
        else
        {
            WinScreenCanvas.GetComponent<CanvasToggle>().SetCanvasToActive();
            WinScreenCanvas.transform.GetChild(0).Find("Time").GetComponent<TMP_Text>().text = "Time taken: " + timer.GetComponent<TMP_Text>().text;
        }
    }

    public void LeaveGame()
    {
        VideoConferenceSetupController videoConferenceSetupController = FindObjectOfType<VideoConferenceSetupController>();
        videoConferenceSetupController.LeaveConference();
        PhotonNetwork.LeaveRoom(true);
        PhotonNetwork.LoadLevel((int)SceneLoader.SceneBuildIndexes.startScene);
    }
}
