using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseItemUnlock: MonoBehaviour
{

    public string itemToUse;
    [SerializeField] private string textBefore, textAfter, title;
    [SerializeField] private GameObject unlockedObject, closedObject, QRPrinter;
    Hints hints;
    public bool noHint, isScanner;
    // Start is called before the first frame update
    void Start()
    {
        hints = FindObjectOfType<Hints>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckUse()
    {
        if (unlockedObject.GetComponent<CheckLocked>().GetStatus() == false)
        {
            unlockedObject.SetActive(true);
            closedObject.SetActive(false);
        }
        else
        {
            if (ItemButton.selectedItem == itemToUse)
            {
                CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
                unlockedObject.SetActive(true);
                closedObject.SetActive(false);
                unlockedObject.GetComponent<CheckLocked>().SetStatus(false);
                QueuedNotification.NotificationInfo notificationInfo = new();
                notificationInfo.title = title;
                notificationInfo.message = textAfter;
                notificationInfo.durationSeconds = 2;
                QueuedNotification.instance.QueueNotification(notificationInfo);
                if (isScanner)
                {
                    QRPrinter.GetComponent<ScannerClicked>().close();
                }
                if (noHint = false)
                {
                    hints.CompletedPuzzle();
                }
            }
            else
            {
                QueuedNotification.NotificationInfo notificationInfo = new();
                notificationInfo.title = title;
                notificationInfo.message = textBefore;
                notificationInfo.durationSeconds = 2;
                QueuedNotification.instance.QueueNotification(notificationInfo);
            }
        }
        
    }
}
