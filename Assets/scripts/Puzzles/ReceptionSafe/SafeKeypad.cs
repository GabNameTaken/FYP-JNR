using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class SafeKeypad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] keycodeInput;
    [SerializeField] private Sprite[] img;
    [SerializeField] GameObject safe, pager, keypad, wall, pagerhb, numberdisplay;
    private GameObject player;
    string inputText;
    void Start()
    {
        clearKeypadInput();
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (keycodeInput[0].text == "3" && keycodeInput[1].text == "9" && keycodeInput[2].text == "7")
        {
            StartCoroutine(rightCode());
        }
        else if (keycodeInput[2].text != "")
        {
            StartCoroutine(wrongCode());
        }

        if (keycodeInput[0].text == "")
        {
            //indicator.SetTrigger("reset");
        }
        else if (keycodeInput[0].text != "" && keycodeInput[1].text == "")
        {
            //indicator.SetTrigger("input1");
        }
        else if (keycodeInput[0].text != "" && keycodeInput[1].text != "" && keycodeInput[2].text == "")
        {
            //indicator.SetTrigger("input2");
        }

    }

    private void Update()
    { 
        OnClick_checkCode();
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

    public void objecttaken()
    {
        safe.GetComponent<Image>().sprite = img[2];
        player.GetComponent<SyncInventory>().CallPickupItem("Pager");
        pager.SetActive(true);
    }

    IEnumerator wrongCode()
    {
        changeImageColorRed();
        keypad.SetActive(false);
        yield return new WaitForSeconds(2f);
        keypad.SetActive(true);
        changeImageColorOrigin();
        clearKeypadInput();
    }
    IEnumerator rightCode()
    {
        changeImageColorGreen();
        yield return new WaitForSeconds(1f);
        safe.GetComponent<Image>().sprite = img[1];
        clearKeypadInput();
        changeImageColorOrigin();
        pager.gameObject.SetActive(true);
        pagerhb.gameObject.SetActive(true);
        keypad.gameObject.SetActive(false);
        numberdisplay.SetActive(false);
        wall.GetComponent<ReceptionSafe>().OpenSafe(true);
        //VarOverScenes.door_receptionUnlocked = true;
        // this.gameObject.SetActive(false);
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
