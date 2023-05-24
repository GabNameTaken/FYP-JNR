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
    [SerializeField] Sprite invalidVerificationImage;
    [SerializeField] Sprite validVerificationImage;
    public void CheckInput()
    {
        if (inputField.text.ToUpper() == password.ToUpper())
        {
            verificationImage.sprite = validVerificationImage;
            GameSoundManager.instance.PlaySound("PCLogin");
            StartCoroutine(EndGame());
        }
        else
        {
            verificationImage.sprite = invalidVerificationImage;
        }
    }
    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3f);

        object[] content = new object[] { true };
        PhotonNetwork.RaiseEvent(RaiseEventManager.endGame, content, new RaiseEventOptions { Receivers = ReceiverGroup.All }, SendOptions.SendReliable);
    }
}
