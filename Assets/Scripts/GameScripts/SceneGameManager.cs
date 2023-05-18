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
    public float time;
    private float timeToDisplay;
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
            timeToDisplay = timer.gameDurationSeconds - time;
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            WinScreenCanvas.GetComponent<CanvasToggle>().SetCanvasToActive();
            WinScreenCanvas.transform.GetChild(0).Find("Time").GetComponent<TMP_Text>().text = "Time taken: " + string.Format("{0:00}:{1:00}", minutes, seconds);
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
