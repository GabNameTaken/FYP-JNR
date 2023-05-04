using UnityEngine;
using Photon.Pun;
using TMPro;
using Hashtable = ExitGames.Client.Photon.Hashtable;
using System.Collections;
using ExitGames.Client.Photon;
using Photon.Realtime;

public class GameTimer : MonoBehaviourPunCallbacks
{
    [SerializeField] SessionInfo sessionInfo;
    [SerializeField] TextMeshProUGUI timerText;

    private const string START_TIME_KEY = "GameStartTime";

    bool isTimerRunning;
    float currentTimeSeconds;
    float gameDurationSeconds;
    int gameStartTimeMilliSeconds;
    int timeElapsedMilliSeconds;

    public delegate void OnTimerEnded();
    public OnTimerEnded onTimerEnded;

    public float CurrentTimeSeconds { get => currentTimeSeconds; }

    private void Start()
    {
        if (PhotonNetwork.InRoom)
        {
            OnJoinedRoom();
        }
    }

    public override void OnJoinedRoom()
    {
        if (!IsGameTimerInitialised())
        {
            InitialiseGameTimer();
        }
        else
        {
            GetStartTime();
        }

        GetTotalGameTime();

        if (PhotonNetwork.IsMasterClient)
            StartCoroutine(TimerCountdown());
    }

    public void StopTimer()
    {
        if (isTimerRunning) StopCoroutine(TimerCountdown());
    }

    private bool IsGameTimerInitialised()
    {
        return PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue(START_TIME_KEY, out _);
    }
    private void InitialiseGameTimer()
    {
        gameStartTimeMilliSeconds = (int)PhotonNetwork.ServerTimestamp;
        Hashtable props = new Hashtable
            {
                {START_TIME_KEY, gameStartTimeMilliSeconds}
            };
        PhotonNetwork.CurrentRoom.SetCustomProperties(props);
    }
    private void GetStartTime()
    {
        PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue(START_TIME_KEY, out object time);
        gameStartTimeMilliSeconds = (int)time;
    }

    private void GetTotalGameTime()
    {
        gameDurationSeconds = sessionInfo.GameDurationMinutes * 60;
    }    

    IEnumerator TimerCountdown()
    {
        isTimerRunning = true;

        currentTimeSeconds = gameDurationSeconds;

        while(currentTimeSeconds > 0)
        {
            timeElapsedMilliSeconds = PhotonNetwork.ServerTimestamp - gameStartTimeMilliSeconds;
            currentTimeSeconds = gameDurationSeconds - timeElapsedMilliSeconds / 1000;

            //DisplayTime(currentTimeSeconds);
            object[] content = new object[] { currentTimeSeconds };
            PhotonNetwork.RaiseEvent(RaiseEventManager.syncTimer, content, new RaiseEventOptions { Receivers = ReceiverGroup.All }, SendOptions.SendReliable);


            yield return new WaitForSeconds(1);
        }

        onTimerEnded?.Invoke();

        isTimerRunning = false;
    }

    public void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = "";
        if (timeToDisplay > 0)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else if (timeToDisplay <= 0)
        {
            timerText.text = "GAME OVER";

            object[] content = new object[] { false };
            PhotonNetwork.RaiseEvent(RaiseEventManager.endGame, content, new RaiseEventOptions { Receivers = ReceiverGroup.All }, SendOptions.SendReliable);
        }
    }

}
