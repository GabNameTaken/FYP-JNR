using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class StartGame : MonoBehaviour
{
    [Header("Start Condition")]
    [SerializeField] int minNoOfPlayers;
    [SerializeField] int idealNoOfPlayers;
    [SerializeField] float longCountdownTimeSeconds;
    [SerializeField] float shortCountdownTimeSeconds;

    [SerializeField] RoomTimer roomTimer;
    [SerializeField] ReadySystem readySystem;
    [SerializeField] LevelLoader levelLoader;

    private void OnEnable()
    {
        roomTimer.OnCountdownTimerHasExpired += ChangeScene;
    }

    private void OnDisable()
    {
        roomTimer.OnCountdownTimerHasExpired -= ChangeScene;
    }

    public void AttemptStartGame()
    {
        if (IdealPlayerCountReached())
        {
            BeginCountdownTimer(shortCountdownTimeSeconds);
        }
        else if (MinPlayerCountReached())
        {
            BeginCountdownTimer(longCountdownTimeSeconds);
        }
    }

    public void CancelStartGame()
    {
        roomTimer.StopTimer();
    }

    private void ChangeScene()
    {
        levelLoader.StartGame();
    }

    private bool MinPlayerCountReached()
    {
        return NumberOfPlayersInRoom() >= minNoOfPlayers;
    }

    private bool IdealPlayerCountReached()
    {
        return NumberOfPlayersInRoom() >= idealNoOfPlayers;
    }

    private int NumberOfPlayersInRoom()
    {
        return PhotonNetwork.CurrentRoom.PlayerCount;
    }

    private void BeginCountdownTimer(float seconds)
    {
        roomTimer.SetCountdownTimeSeconds(seconds);
        roomTimer.StartTimer();
    }
}
