using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldQuiz : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] string password;
    public void CheckInput()
    {
        if (inputField.text.ToUpper() == password.ToUpper())
        {
            EndGame();
        }
    }
    private void EndGame()
    {

    }
}
