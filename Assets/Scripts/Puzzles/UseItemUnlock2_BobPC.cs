using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseItemUnlock2_BobPC : MonoBehaviour
{
    public string itemToUse;
    [SerializeField] private string notifTitle, notifMessage;
    [SerializeField] private GameObject unlockedObject, unlockedObject2, closedObject, closedObject2;
    Hints hints;

    public string soundName;

    void Start()
    {
        hints = FindObjectOfType<Hints>();
    }

    public void CheckUse()
    {
        if (ItemButton.selectedItem == itemToUse)
        {
            CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
            unlockedObject.SetActive(true);
            unlockedObject2.SetActive(true);
            closedObject.SetActive(false);
            closedObject2.SetActive(false);
            this.gameObject.SetActive(false);
            hints.CompletedPuzzle(itemToUse);

            GameSoundManager.PlaySound(soundName);
        }
        else
        {
              QueuedNotification.NotificationInfo notificationInfo = new();
              notificationInfo.title = notifTitle;
              notificationInfo.message = notifMessage;
              notificationInfo.durationSeconds = 5;
              QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }
}
