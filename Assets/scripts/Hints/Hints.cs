using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hints : MonoBehaviour
{
    [SerializeField] GameObject[] hint;
    [SerializeField] TextMeshProUGUI counter;

    [SerializeField] GameObject Confirmation, NoHints, HintPage;

    int numberOfHints = 100;
    int currentHint = 0;
    bool hintUsed = false;

    void Start()
    {
        counter.text = "You have " + numberOfHints + " hints left";
    }

    public void HintButtonPress()
    {
        if (numberOfHints <= 0)
        {
            NoHints.SetActive(true);
        }
        else if (hintUsed == true)
        {
            hint[currentHint].SetActive(true);
            HintPage.SetActive(true);
        }
        else
        {
            Confirmation.SetActive(true);
        }
    }

    public void YesButtonPress()
    {
        Confirmation.SetActive(false);
        numberOfHints--;
        counter.text = "You have " + numberOfHints + " hints left";
        hint[currentHint].SetActive(true);
        HintPage.SetActive(true);
    }

    public void CloseHintPress()
    {
        hint[currentHint].SetActive(false);
        HintPage.SetActive(false);
        hintUsed = true;
    }

    public void CompletedPuzzle()
    {
        hintUsed = false;
        currentHint++;
    }
}
