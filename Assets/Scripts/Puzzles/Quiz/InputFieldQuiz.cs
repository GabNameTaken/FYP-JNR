using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using Photon.Pun;
using ExitGames.Client.Photon;
using Photon.Realtime;

public class InputFieldQuiz : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] string password;
    [SerializeField] Image verificationImage;
    [SerializeField] Sprite defaultVerificationImage;
    [SerializeField] Sprite invalidVerificationImage;
    [SerializeField] Sprite validVerificationImage;

    public void CheckInput()
    {
        if (inputField.text.Length != 8)
            return;

        if (inputField.text.ToLower() == password)
        {
            StartCoroutine(EndGame());
        }
        else
        {
            StartCoroutine(WrongCode());
        }
    }

    private IEnumerator WrongCode()
    {
        verificationImage.sprite = invalidVerificationImage;
        inputField.DeactivateInputField();
        GameSoundManager.instance.PlaySound("Error");
        yield return new WaitForSeconds(2f);

        verificationImage.sprite = defaultVerificationImage;
        inputField.text = "";
        inputField.ActivateInputField();
    }

    private IEnumerator EndGame()
    {
        verificationImage.sprite = validVerificationImage;
        GameSoundManager.instance.PlaySound("PCLogin");
        yield return new WaitForSeconds(2f);

        object[] content = new object[] { true };
        PhotonNetwork.RaiseEvent(RaiseEventManager.endGame, content, new RaiseEventOptions { Receivers = ReceiverGroup.All }, SendOptions.SendReliable);
    }
}
