using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] int answer;
    [SerializeField] string[] optionText;

    [SerializeField] TextMeshProUGUI correctText;
    [SerializeField] GameObject correctPanel;
    [SerializeField] TextMeshProUGUI incorrectText;
    [SerializeField] GameObject incorrectPanel;

    //To set navigation arrow active
    [SerializeField] LockedDoor lockDoorRef;

    public void PickOption(int option)
    {
        if (option == answer)
        {
            correctText.text = optionText[option];
            correctPanel.SetActive(true);
        }
        else
        {
            incorrectText.text = optionText[option];
            incorrectPanel.SetActive(true);
        }
    }

    public void CloseCorrectPopup()
    {
        lockDoorRef.UnlockDoor();
    }

    public void CloseIncorrectPopup()
    {
        incorrectPanel.SetActive(false);
    }
}
