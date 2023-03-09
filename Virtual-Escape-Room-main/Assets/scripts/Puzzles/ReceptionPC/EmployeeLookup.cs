using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EmployeeLookup : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] Image img_employeeLookup;
    
    // Array containing the employee lookup sprites
    // 0 : Adam
    // 1 : Bob
    // 2 : Collin
    // 3 : Daniel
    // 4 : Gabriel
    // 5 : John
    // 6 : Robin
    // 7 : Search List
    // 8 : Search List Error
    [SerializeField] Sprite[] img_employeeLookup_list;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            EL_onCheckName();
        }
    }

    public void EL_onCheckName()
    {
        if (input.text == "Adam")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[0];
        }
        else if (input.text == "Bob")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[1];
        }
        else if (input.text == "Collin")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[2];
        }
        else if (input.text == "Daniel")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[3];
        }
        else if (input.text == "Gabriel")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[4];
        }
        else if (input.text == "John")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[5];
        }
        else if (input.text == "Robin")
        {
            img_employeeLookup.sprite = img_employeeLookup_list[6];
        }
        else
        {
            img_employeeLookup.sprite = img_employeeLookup_list[8];
        }
    }

    public void EL_onCloseTab()
    {
        img_employeeLookup.sprite = img_employeeLookup_list[7];
        input.text = "";
    }
}
