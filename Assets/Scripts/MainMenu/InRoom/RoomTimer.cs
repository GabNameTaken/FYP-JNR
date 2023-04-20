using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Pun.UtilityScripts;

public class RoomTimer : MonoBehaviour
{
    [SerializeField] CountdownTimer countdownTimer;
    [SerializeField] Text countdownText;
    [SerializeField] TextMeshProUGUI timerText;

    [SerializeField] private float countdownInSeconds;

    public delegate void CountdownTimerHasExpired();
    public event CountdownTimerHasExpired OnCountdownTimerHasExpired;

    private bool isStopped = true;

    private void OnEnable()
    {
        CountdownTimer.OnCountdownTimerHasExpired += CountdownTimer_OnCountdownTimerHasExpired;
    }
    private void OnDisable()
    {
        CountdownTimer.OnCountdownTimerHasExpired -= CountdownTimer_OnCountdownTimerHasExpired;
    }
    private void CountdownTimer_OnCountdownTimerHasExpired()
    {
        if (!isStopped) OnCountdownTimerHasExpired?.Invoke();
    }
    public void SetCountdownTimeSeconds(float time)
    {
        countdownInSeconds = time;
    }
    public void StartTimer()
    {
        Debug.Log("ENABLE TIMER");
        timerText.gameObject.SetActive(true);
        countdownTimer.Countdown = countdownInSeconds;
        isStopped = false;

        CountdownTimer.SetStartTime();
    }
    public void StopTimer()
    {
        timerText.gameObject.SetActive(false);
        isStopped = true;
    }
}
