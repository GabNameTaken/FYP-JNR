using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class safe_puzzles_check : MonoBehaviour
{
    public string dial_lock_code;
    [SerializeField] TMP_Text dial1_letter, dial2_letter, dial3_letter, dial4_letter;
    [SerializeField] GameObject Keypad_lock, canvas_to_close, opened_safe_canvas;
    Hints hints;
    // Start is called before the first frame update
    private void Awake()
    {
        hints = FindObjectOfType<Hints>();
    }
    public void on_click_check()
    {
        if (dial_lock_code == (dial1_letter.text 
            + dial2_letter.text 
            + dial3_letter.text 
            + dial4_letter.text) && 
            Keypad_lock.GetComponent<Keypad>().boss_safe_keypad_solved)
        {
            opened_safe_canvas.SetActive(true);
            canvas_to_close.SetActive(false);
            hints.CompletedPuzzle();
        }
        else
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Boss Safe";
            notificationInfo.message = "Locked";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }

    public void checkcode()
    {
        if (dial_lock_code == (dial1_letter.text
            + dial2_letter.text
            + dial3_letter.text
            + dial4_letter.text))
        {
            QueuedNotification.NotificationInfo notificationInfo = new();
            notificationInfo.title = "Boss Safe Dials";
            notificationInfo.message = "Solved";
            notificationInfo.durationSeconds = 2;
            QueuedNotification.instance.QueueNotification(notificationInfo);
        }
    }
}