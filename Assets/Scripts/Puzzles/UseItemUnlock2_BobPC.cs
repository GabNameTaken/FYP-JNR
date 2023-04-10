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
        if (ItemButton.selectedItem == itemToUse)
        {
            CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
            unlockedObject.SetActive(true);
            unlockedObject2.SetActive(true);
            closedObject.SetActive(false);
            closedObject2.SetActive(false);
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