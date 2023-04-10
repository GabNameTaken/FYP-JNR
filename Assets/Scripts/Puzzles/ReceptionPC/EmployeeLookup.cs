using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EmployeeLookup : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] GameObject mainPage;
    
    // Array containing the employee lookup sprites
    // 0 : Adam
    // 1 : Bob
    // 2 : Collin
    // 3 : Daniel
    // 4 : Gabriel
    // 5 : James
    // 6 : Grace
    // 7 : Search List Error
    [SerializeField] GameObject[] employeePageList;

    [SerializeField] GameObject backButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            OnCheckName();
        }
    }

    public void OnCheckName()
    {
        backButton.SetActive(true);

        foreach (GameObject page in employeePageList)
        {
            page.SetActive(false);
        }

        if (input.text == "Adam" || input.text == "adam")
        {
            mainPage.SetActive(false);
            employeePageList[0].SetActive(true);
        }
        else if (input.text == "Bob" || input.text == "bob")
        {
            mainPage.SetActive(false);
            employeePageList[1].SetActive(true);
        }
        else if (input.text == "Collin" || input.text == "collin")
        {
            mainPage.SetActive(false);
            employeePageList[2].SetActive(true);
        }
        else if (input.text == "Daniel" || input.text == "daniel")
        {
            mainPage.SetActive(false);
            employeePageList[3].SetActive(true);
        }
        else if (input.text == "Gabriel" || input.text == "gabriel")
        {
            mainPage.SetActive(false);
            employeePageList[4].SetActive(true);
        }
        else if (input.text == "James" || input.text == "james")
        {
            mainPage.SetActive(false);
            employeePageList[5].SetActive(true);
        }
        else if (input.text == "Grace" || input.text == "grace")
        {
            mainPage.SetActive(false);
            employeePageList[6].SetActive(true);
        }
        else
        {
            mainPage.SetActive(false);
            employeePageList[7].SetActive(true);
        }
    }

    public void OnCloseTab()
    {
        foreach(GameObject employeePage in employeePageList)
        {
            employeePage.SetActive(false);
        }

        mainPage.SetActive(true);
        backButton.SetActive(false);
        input.text = "";
    }
}
