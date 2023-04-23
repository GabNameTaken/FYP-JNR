using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mastermind : MonoBehaviour
{
    [SerializeField] int attempts;
    [SerializeField] int numPins;

    [SerializeField] TextMeshProUGUI[] slots;

    [SerializeField] GameObject correctMarker, differentMarker, wrongMarker;

    [SerializeField] GameObject panelCompletedImage;

    string numberCode = "";

    void Start()
    {
        for (int i = 0; i < slots.Length; ++i)
        {
            numberCode += Random.Range(1, numPins);
        }
    }

    public void CheckCode()
    {
        string input = "";
        for (int i = 0; i < slots.Length; ++i)
        {
            input += slots[i].text;
        }

        if (input == numberCode)
        {
            panelCompletedImage.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            for (int i = 0; i < slots.Length; ++i)
            {
                if (numberCode[i].ToString() == slots[i].text)
                {

                }
                else if (numberCode.Contains(slots[i].text))
                {

                }
            }
        }
    }
}