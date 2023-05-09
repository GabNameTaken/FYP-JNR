using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] keycodeInput;
    [SerializeField] Image[] imageCol;
    string inputText;
    [SerializeField, SerializeReference] LockedDoor lockedDoor;
    Hints hints;
    public bool boss_safe_check;
    public bool boss_safe_keypad_solved;
    public GameObject boss_safe_keypad_view_button, safe;
    public GameObject safe_canvas;
    void Start()
    {
        clearKeypadInput();
        boss_safe_keypad_solved = false;
        hints = FindObjectOfType<Hints>();
    }

    void checkKeypadInput()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            if (keycodeInput[i].text == "")
            {
                keycodeInput[i].text = inputText;
                break;
            }
        }
    }

    void OnClick_checkCode()
    {
        if (boss_safe_check) // For boss' safe keypad (7582361)
        {
            if (keycodeInput[0].text == "7" && 
                keycodeInput[1].text == "5" && 
                keycodeInput[2].text == "8" && 
                keycodeInput[3].text == "2" &&
                keycodeInput[4].text == "3" &&
                keycodeInput[5].text == "6" &&
                keycodeInput[6].text == "1")
            {
                StartCoroutine(rightCode_boss_Safe());
            }
            else if (keycodeInput[6].text != "")
            {
                StartCoroutine(wrongCode());
            }
        }
        else
        {
            if (keycodeInput[0].text == "5" && keycodeInput[1].text == "3" && keycodeInput[2].text == "9" && keycodeInput[3].text == "8")
            {
                StartCoroutine(rightCode());
            }
            else if (keycodeInput[3].text != "")
            {
                StartCoroutine(wrongCode());
            }
        }
    }

    private void Update()
    {
        OnClick_checkCode();
    }

    public void OnClick_deleteKeypadInput()
    {
        foreach (TextMeshProUGUI _text in keycodeInput.Reverse())
        {
            if (_text.text != "")
            {
                _text.text = "";
                break;
            }
        }
    }

    void clearKeypadInput()
    {
        foreach (TextMeshProUGUI _text in keycodeInput)
        {
            _text.text = "";
        }
    }

    public void OnClick_1()
    {
        inputText = "1";
        checkKeypadInput();
    }
    public void OnClick_2()
    {
        inputText = "2";
        checkKeypadInput();
    }
    public void OnClick_3()
    {
        inputText = "3";
        checkKeypadInput();
    }
    public void OnClick_4()
    {
        inputText = "4";
        checkKeypadInput();
    }
    public void OnClick_5()
    {
        inputText = "5";
        checkKeypadInput();
    }
    public void OnClick_6()
    {
        inputText = "6";
        checkKeypadInput();
    }
    public void OnClick_7()
    {
        inputText = "7";
        checkKeypadInput();
    }
    public void OnClick_8()
    {
        inputText = "8";
        checkKeypadInput();
    }
    public void OnClick_9()
    {
        inputText = "9";
        checkKeypadInput();
    }
    public void OnClick_0()
    {
        inputText = "0";
        checkKeypadInput();
    }

    IEnumerator wrongCode()
    {
        GameSoundManager.PlaySound("SafeError");
        changeImageColorRed();
        yield return new WaitForSeconds(1f);
        clearKeypadInput();
        changeImageColorOrigin();
    }

    IEnumerator rightCode()
    {
        GameSoundManager.PlaySound("LockSuccess");
        changeImageColorGreen();
        yield return new WaitForSeconds(1f);
        hints.CompletedPuzzle("ReceptionDoor");
        clearKeypadInput();
        changeImageColorOrigin();
        QueuedNotification.NotificationInfo notificationInfo = new();
        notificationInfo.title = "Keypad Door";
        notificationInfo.message = "Unlocked";
        notificationInfo.durationSeconds = 2;
        QueuedNotification.instance.QueueNotification(notificationInfo);
        lockedDoor.UnlockDoor();
        this.gameObject.SetActive(false);
    }

    IEnumerator rightCode_boss_Safe()
    {
        changeImageColorGreen();
        yield return new WaitForSeconds(1f);
        QueuedNotification.NotificationInfo notificationInfo = new();
        notificationInfo.title = "Boss Safe Keypad";
        notificationInfo.message = "Solved";
        notificationInfo.durationSeconds = 2;
        QueuedNotification.instance.QueueNotification(notificationInfo);
        hints.CompletedPuzzle("BossKeypad");
        boss_safe_keypad_solved = true;
        safe.GetComponent<BoxCollider>().enabled = true;
        this.gameObject.SetActive(false);
        boss_safe_keypad_view_button.SetActive(false);
        safe_canvas.SetActive(true);
    }

    void changeImageColorRed()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.red;
        }
       
    }
    void changeImageColorGreen()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.green;
        }
    }

    void changeImageColorOrigin()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.white;
        }
    }
}
