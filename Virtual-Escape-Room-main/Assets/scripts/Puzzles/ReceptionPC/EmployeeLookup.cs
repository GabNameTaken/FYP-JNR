using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EmployeeLookup : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] GameObject employee_lookup_menu;
    
    // Array containing the employee lookup sprites
    // 0 : Adam
    // 1 : Bob
    // 2 : Collin
    // 3 : Daniel
    // 4 : Gabriel
    // 5 : James
    // 6 : Robin
    // 7 : Search List Error
    [SerializeField] GameObject[] employee_lookup_pages_list;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            EL_onCheckName();
        }
    }

    public void EL_onCheckName()
    {
        if (input.text == "Adam" || input.text == "adam")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[0].SetActive(true);
        }
        else if (input.text == "Bob" || input.text == "bob")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[1].SetActive(true);
        }
        else if (input.text == "Collin" || input.text == "collin")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[2].SetActive(true);
        }
        else if (input.text == "Daniel" || input.text == "daniel")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[3].SetActive(true);
        }
        else if (input.text == "Gabriel" || input.text == "gabriel")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[4].SetActive(true);
        }
        else if (input.text == "James" || input.text == "james")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[5].SetActive(true);
        }
        else if (input.text == "Robin" || input.text == "robin")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[6].SetActive(true);
        }
        else if (input.text == "Grace" || input.text == "grace")
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[8].SetActive(true);
        }
        else // Error
        {
            employee_lookup_menu.SetActive(false);
            employee_lookup_pages_list[7].SetActive(true);
        }
    }

    public void EL_onCloseTab()
    {
        foreach(GameObject employee_page in employee_lookup_pages_list)
        {
            employee_page.SetActive(false);
        }
        employee_lookup_menu.SetActive(true);
        input.text = "";
    }
}
