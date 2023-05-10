using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class SafeKeypad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] keycodeInput;
    [SerializeField] Sprite[] img;
    [SerializeField] GameObject safe, safeItems, keypad, wall, pagerButton, numberDisplay;
    private GameObject player;

    Hints hints;

    void Start()
    {
        ClearKeypadInput();
        player = GameObject.FindGameObjectWithTag("Player");

        hints = FindObjectOfType<Hints>();
    }

    void KeypadInput(string input)
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            if (keycodeInput[i].text == "")
            {
                keycodeInput[i].text = input;
                if (i == 2)
                    OnClickCheckCode();
                break;
            }
        }
    }

    void OnClickCheckCode()
    {
        if (keycodeInput[0].text == "3" && keycodeInput[1].text == "9" && keycodeInput[2].text == "7")
        {
            StartCoroutine(RightCode());
        }
        else if (keycodeInput[2].text != "")
        {
            StartCoroutine(WrongCode());
        }
    }

    void ClearKeypadInput()
    {
        keycodeInput[0].text = "";
        keycodeInput[1].text = "";
        keycodeInput[2].text = "";
    }

    public void OnClick_1()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("1");
    }
    public void OnClick_2()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("2");
    }
    public void OnClick_3()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("3");
    }
    public void OnClick_4()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("4");
    }
    public void OnClick_5()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("5");
    }
    public void OnClick_6()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("6");
    }
    public void OnClick_7()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("7");
    }
    public void OnClick_8()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("8");
    }
    public void OnClick_9()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("9");
    }
    public void OnClick_0()
    {
        GameSoundManager.PlaySound("Keypad");
        KeypadInput("0");
    }

    public void ObjectTaken()
    {
        safe.GetComponent<Image>().sprite = img[2];
        player.GetComponent<SyncInventory>().CallPickupItem("Pager");
        pagerButton.SetActive(false);
        safeItems.SetActive(true);
    }

    IEnumerator WrongCode()
    {
        GameSoundManager.PlaySound("SafeError");
        ChangeImageColorRed();
        keypad.SetActive(false);
        yield return new WaitForSeconds(2);
        keypad.SetActive(true);
        ChangeImageColorOrigin();
        ClearKeypadInput();
    }

    IEnumerator RightCode()
    {
        ChangeImageColorGreen();
        yield return new WaitForSeconds(1);
        GameSoundManager.PlaySound("KeyUnlock");
        safe.GetComponent<Image>().sprite = img[1];
        ClearKeypadInput();
        ChangeImageColorOrigin();
        safeItems.SetActive(true);
        pagerButton.SetActive(true);
        keypad.SetActive(false);
        numberDisplay.SetActive(false);
        wall.GetComponent<ReceptionSafe>().OpenSafe(true);
        hints.CompletedPuzzle("ReceptionSafe");
    }

    void ChangeImageColorRed()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.red;
        }

    }
    void ChangeImageColorGreen()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.green;
        }
    }

    void ChangeImageColorOrigin()
    {
        for (int i = 0; i < keycodeInput.Length; i++)
        {
            keycodeInput[i].color = Color.white;
        }
    }
}
