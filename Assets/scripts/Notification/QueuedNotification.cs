using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueuedNotification : MonoSingletonTemplate<QueuedNotification>
{
    public struct NotificationInfo
    {
        public string title;
        public string message;
        public Sprite imageSprite;
        public float durationSeconds;
    }


    [SerializeField] int notificationQueueLimit;
    [SerializeField] float notificationMinimumDurationSeconds;

    [SerializeField] NotificationBox notificationBox;

    readonly Queue<NotificationInfo> notificationQueue = new();

    bool isCoroutineRunning = false;

    private void Awake()
    {
        InitializeSingleton(this, false);
    }

    private void Start()
    {
        notificationBox.gameObject.SetActive(false);
    }

    public void QueueNotification(NotificationInfo notificationInfo)
    {
        notificationQueue.Enqueue(notificationInfo);

        if (notificationQueue.Count > notificationQueueLimit)
        {
            notificationQueue.Dequeue();
        }

        if (!isCoroutineRunning)
        {
            StartCoroutine(DisplayNotification());
        }
    }

    IEnumerator DisplayNotification()
    {
        isCoroutineRunning = true;

        while(notificationQueue.Count > 0)
        {
            NotificationInfo info = notificationQueue.Dequeue();

            notificationBox.gameObject.SetActive(true);
            float durationSeconds = notificationMinimumDurationSeconds;
            if (info.durationSeconds > notificationMinimumDurationSeconds) durationSeconds = info.durationSeconds;
            notificationBox.Initialise(durationSeconds);

            ConfigureNotificationBox(info);
            
            yield return new WaitWhile(() => notificationBox.gameObject.activeSelf);
        }

        isCoroutineRunning = false;
    }

    private void ConfigureNotificationBox(NotificationInfo info)
    {
        notificationBox.SetTitle(info.title);
        notificationBox.SetMessage(info.message);
        notificationBox.SetImageSprite(info.imageSprite);
    }
}
