using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PC1 : MonoBehaviour
{
    [SerializeField] string password;
    [SerializeField] TMP_InputField passwordInput;

    bool activeEyeIcon = false;

    [SerializeField] TextMeshProUGUI confirmText;
    [SerializeField] TMP_Text eyeconText;

    public void OnClickEyecon()
    {
        activeEyeIcon = !activeEyeIcon;
        if (activeEyeIcon)
        {
            passwordInput.contentType = TMP_InputField.ContentType.Standard;
            eyeconText.text = "hide";
        }
        else
        {
            passwordInput.contentType = TMP_InputField.ContentType.Password;
            eyeconText.text = "show";
        }
        passwordInput.ForceLabelUpdate();
    }

    public void OnClick_Login()
    {
        if (passwordInput.text == password)
        {
            confirmText.text = "Logged in";
            //add new screen or smth
        }
        else
        {
            confirmText.text = "Wrong password. Please try again.";
        }
    }
}
