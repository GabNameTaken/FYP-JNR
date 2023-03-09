using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReceptionPCLogin : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public string password;
    [SerializeField] GameObject pcScreen, hints, tip;
    public GameObject toDisable;

    public void passwordCheck()
    {
        if (passwordInput.text == password)
        {
            pcScreen.SetActive(true);
            toDisable.SetActive(false);
            hints.GetComponent<Hints>().CompletedPuzzle();
            tip.SetActive(true);
        }
    }
}
