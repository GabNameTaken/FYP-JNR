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
        KeypadInput("1");
    }
    public void OnClick_2()
    {
        KeypadInput("2");
    }
    public void OnClick_3()
    {
        KeypadInput("3");
    }
    public void OnClick_4()
    {
        KeypadInput("4");
    }
    public void OnClick_5()
    {
        KeypadInput("5");
    }
    public void OnClick_6()
    {
        KeypadInput("6");
    }
    public void OnClick_7()
    {
        KeypadInput("7");
    }
    public void OnClick_8()
    {
        KeypadInput("8");
    }
    public void OnClick_9()
    {
        KeypadInput("9");
    }
    public void OnClick_0()
    {
        KeypadInput("0");
    }

    public void ObjectTaken()
    {
        safe.GetComponent<Image>().sprite = img[2];
        player.GetComponent<SyncInventory>().CallPickupItem("Pager");
        safeItems.SetActive(true);
    }

    IEnumerator WrongCode()
    {
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
        safe.GetComponent<Image>().sprite = img[1];
        ClearKeypadInput();
        ChangeImageColorOrigin();
        safeItems.SetActive(true);
        pagerButton.SetActive(true);
        keypad.SetActive(false);
        numberDisplay.SetActive(false);
        wall.GetComponent<ReceptionSafe>().OpenSafe(true);
        hints.CompletedPuzzle();
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
