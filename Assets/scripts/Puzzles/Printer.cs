using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : InteractableObject
{
    [SerializeField] GameObject qrcode;
    private int pcCompleteCounter = 0;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public override void OnClick()
    {
        if (pcCompleteCounter == 4)
        {
            player.GetComponent<SyncInventory>().CallPickupItem("QRCode");
            qrcode.SetActive(true);
        }
        else
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Printer";
            notificationInfo.message = "Nothing to print yet";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }

    public void CompletedPC()
    {
        pcCompleteCounter++;
        Debug.Log("puzzle complete: " + pcCompleteCounter);
        if (pcCompleteCounter == 1)
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Printer";
            notificationInfo.message = "1/4 Computers Logged In";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
        else if (pcCompleteCounter == 2)
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Printer";
            notificationInfo.message = "2/4 Computers Logged In";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
        else if (pcCompleteCounter == 3)
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Printer";
            notificationInfo.message = "3/4 Computers Logged In";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
        else if (pcCompleteCounter == 4)
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Printer";
            notificationInfo.message = "Something is getting printed";
            notificationInfo.durationSeconds = 5;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }
}
