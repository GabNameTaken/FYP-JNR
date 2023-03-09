using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class SafeKeypad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] keycodeInput;
    [SerializeField] private Animator detect1;
    [SerializeField] private Animator detect2;
    [SerializeField] private Animator detect3;
    [SerializeField] private Sprite[] img;
    [SerializeField] GameObject safe, pager, keypad, d1, d2, d3, wall, pagerhb;
    string inputText;
    void Start()
    {
        clearKeypadInput();
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
        else if (keycodeInput[2].text != "" && keycodeInput[2].text != "7")
        {
            StartCoroutine(wrongCode());
        }

        if (keycodeInput[0].text == "")
        {
            detect1.SetTrigger("waitinginput");
        }
        else if (keycodeInput[1].text == "")
        {
            detect1.SetTrigger("inputsuccess");
            detect2.SetTrigger("waitinginput");
        }
        else if (keycodeInput[2].text == "")
        {
            detect2.SetTrigger("inputsuccess");
            detect3.SetTrigger("waitinginput");
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
    }

    IEnumerator wrongCode()
    {

        yield return new WaitForSeconds(0f);
        detect1.SetTrigger("inputwrong");
        detect2.SetTrigger("inputwrong");
        detect3.SetTrigger("inputwrong");
        //detect2.SetBool("waitinginput",false);
        //detect3.SetBool("waitinginput", false);
        clearKeypadInput();
        
    }
    IEnumerator rightCode()
    {
        //changeImageColorGreen();
        detect3.SetTrigger("inputsuccess");
        yield return new WaitForSeconds(1f);
        safe.GetComponent<Image>().sprite = img[1];
        clearKeypadInput();
        pager.gameObject.SetActive(true);
        pagerhb.gameObject.SetActive(true);
        d1.gameObject.SetActive(false);
        d2.gameObject.SetActive(false);
        d3.gameObject.SetActive(false);
        keypad.gameObject.SetActive(false);
        wall.GetComponent<ReceptionSafe>().OpenSafe(true);
        //VarOverScenes.door_receptionUnlocked = true;
        // this.gameObject.SetActive(false);
    }

}
