using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseItemUnlock2_BobPC : MonoBehaviour
{
    public string itemToUse;
    [SerializeField] private string textBefore, textAfter;
    [SerializeField] private GameObject unlockedObject, unlockedObject2, closedObject, closedObject2;
    Hints hints;
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
        if (unlockedObject.GetComponent<CheckLocked>().GetStatus() == false && unlockedObject2.GetComponent<CheckLocked>().GetStatus() == false)
        {
            unlockedObject.SetActive(true);
            unlockedObject2.SetActive(true);
            closedObject.SetActive(false);
            closedObject2.SetActive(false);
        }
        else
        {
            if (ItemButton.selectedItem == itemToUse)
            {
                CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
                unlockedObject.SetActive(true);
                unlockedObject2.SetActive(true);
                closedObject.SetActive(false);
                closedObject2.SetActive(false);
                unlockedObject.GetComponent<CheckLocked>().SetStatus(false);
                unlockedObject2.GetComponent<CheckLocked>().SetStatus(false);
                hints.CompletedPuzzle();
            }
            else
            {
                QueuedNotification.NotificationInfo notificationInfo = new();
                notificationInfo.title = "RAM Slot";
                notificationInfo.message = "RAM Missing";
                notificationInfo.durationSeconds = 5;
                QueuedNotification.instance.QueueNotification(notificationInfo);
            }
        }

    }

    public void CheckUse2()
    {
        if (ItemButton.selectedItem == itemToUse)
        {
            CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
            unlockedObject.SetActive(true);
            unlockedObject2.SetActive(true);
            closedObject.SetActive(false);
            closedObject2.SetActive(false);
            unlockedObject.GetComponent<CheckLocked>().SetStatus(false);
            unlockedObject2.GetComponent<CheckLocked>().SetStatus(false);
            this.gameObject.SetActive(false);
            hints.CompletedPuzzle();
        }
        else
        {
              QueuedNotification.NotificationInfo notificationInfo = new();
              notificationInfo.title = "Closed PC case";
              notificationInfo.message = "Locked";
              notificationInfo.durationSeconds = 5;
              QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }
}
