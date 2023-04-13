using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatItemUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMsg;
    [SerializeField] Image userImg;
    [SerializeField] TextMeshProUGUI username;

    public void Initialise(string text, Sprite image, string user)
    {
        textMsg.text = text;
        userImg.sprite = image;
        username.text = user;
    }
}
