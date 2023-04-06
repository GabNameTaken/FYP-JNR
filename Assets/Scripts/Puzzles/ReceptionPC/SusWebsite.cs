using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SusWebsite : MonoBehaviour
{
    [SerializeField] string passwordHidden;
    [SerializeField] string passwordRevealed;
    [SerializeField] string pinInput;

    [SerializeField] Image img_eyeIcon;
    // 0 : eyeClose
    // 1 : eyeOpen
    [SerializeField] Sprite[] img_eyecon;

    //Admin password text
    [SerializeField] TextMeshProUGUI passwordText;

    //Enter user pin
    [SerializeField] TMP_InputField inF_pinInput;
    [SerializeField] GameObject go_pinInput;

    void Start()
    {
        passwordText.text = passwordHidden;
    }

    private void Update()
    {
        OnClick_pinInput();
    }

    public void OnClick_pinInput()
    {
        if (inF_pinInput.text == pinInput)
        {
            go_pinInput.SetActive(false);
            img_eyeIcon.sprite = img_eyecon[1];
            passwordText.text = passwordRevealed;
        }
    }
}
