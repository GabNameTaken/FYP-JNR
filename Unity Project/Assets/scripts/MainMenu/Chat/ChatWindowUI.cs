using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class ChatWindowUI : MonoBehaviourPun
{
    #region VARIABLES
    [Header("Chat variables")]
    [SerializeField] ChatItemUI playerChat; //the current player's chat
    [SerializeField] ChatItemUI userChat; //other user's chats
    [SerializeField] Transform container; //container to fit the chats
    [SerializeField] ScrollRect scrollRect; //image
    [SerializeField] TMP_InputField inputField;
    public PlayerInfo playerInfo;
    [SerializeField] List<Sprite> pfpImage;
    #endregion

    #region INSTANTIATE_CHATBOXES
    // Instantiate the current user's chatbox
    private void InstantiateChatbox(string text, Sprite image, string user)
    {
        ChatItemUI newChatbox = Instantiate(playerChat);
        newChatbox.transform.SetParent(container,false);
        newChatbox.transform.position = Vector3.zero;
        newChatbox.transform.localPosition = Vector3.one;
        newChatbox.Initialise(text,image,user);
    }
    // Instantiate the other user's chatboxes
    private void InstantiateOtherUserChatbox(string text, Sprite image, string user)
    {
        ChatItemUI newChatbox = Instantiate(userChat);
        newChatbox.transform.SetParent(container,false);
        newChatbox.transform.position = Vector3.zero;
        newChatbox.transform.localPosition = Vector3.one;
        newChatbox.Initialise(text, image, user);
    }
    #endregion

    // Send the message of both the current and other users
    private void SendMsg()
    {
        if (string.IsNullOrEmpty(inputField.text)) { return; }
        if (inputField.text.Length > 256) { return; }
        if (playerInfo == null) { return; }

        photonView.RPC("ReceiveMsgRPC", RpcTarget.Others, inputField.text, playerInfo.CurrentSprite, PhotonNetwork.NickName);
        InstantiateChatbox(inputField.text, pfpImage[playerInfo.CurrentSprite], PhotonNetwork.NickName);
        StartCoroutine(ScrollToBottom());
        inputField.text = string.Empty;
        inputField.ActivateInputField();
    }

    // On click button, send message to other users
    public void OnClick_SendMsg()
    {
        SendMsg();
    }

    // Scroll to the bottom of the chatbox when player sends message
    IEnumerator ScrollToBottom()
    {
        yield return new WaitForEndOfFrame();
        scrollRect.verticalNormalizedPosition = 0f;
    }

    // Receive the RPC to instantiate the user's chatbox
    [PunRPC]
    public void ReceiveMsgRPC(string text, int img, string user)
    {
        InstantiateOtherUserChatbox(text, pfpImage[img], user);
        StartCoroutine(ScrollToBottom());
    }
}
