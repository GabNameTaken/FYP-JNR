using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinReset : MonoBehaviour
{
    [SerializeField] string username;
    [SerializeField] string password;

    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_InputField passwordInput;

    [SerializeField] Image img_resetPinBgImg;
    // 0 : eyeClose
    // 1 : eyeOpen
    [SerializeField] Sprite[] img_resetPinImg;
    bool activeEyeIcon = false;

    [SerializeField] TextMeshProUGUI confirmText;
    [SerializeField] GameObject resetButton;

    public void OnClickEyecon()
    {
        activeEyeIcon = !activeEyeIcon;
        if (activeEyeIcon)
        {
            passwordInput.contentType = TMP_InputField.ContentType.Standard;
            img_resetPinBgImg.sprite = img_resetPinImg[1];
        }
        else
        {
            passwordInput.contentType = TMP_InputField.ContentType.Password;
            img_resetPinBgImg.sprite = img_resetPinImg[0];
        }
        passwordInput.ForceLabelUpdate();
    }

    public void OnClick_Reset()
    {
        activeEyeIcon = false;
        passwordInput.contentType = TMP_InputField.ContentType.Password;
        nameInput.text = "";
        passwordInput.text = "";
        confirmText.text = "";
        resetButton.SetActive(true);
    }

    public void OnClick_ResetPin()
    {
        if (nameInput.text == username && passwordInput.text == password)
        {
            confirmText.text = "Reset successful. Your new password is: 3982"; 
            resetButton.SetActive(false);
        }
        else if ((nameInput.text == "Adam" || nameInput.text == "Bob" || nameInput.text == "Collin" || nameInput.text == "Daniel" || nameInput.text == "Gabriel" || nameInput.text == "John") && passwordInput.text == password)
        {
            confirmText.text = "Unable to reset. Please send a request to reset on the website.";
        }
        else
        {
            confirmText.text = "Wrong password. Please try again.";
        }
    }
}
