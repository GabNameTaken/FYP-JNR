using Photon.Pun;
using TMPro;
using UnityEngine;

public class NickNameUI : MonoBehaviour
{
    [SerializeField] TMP_InputField nickNameIF;

    [SerializeField] GameObject invalidNameErrorMessage;

    [SerializeField] NavigationPage navigationPage;
    [SerializeField] VideoBackgroundPage nextPage;

    public void OnSetNickName()
    {
        HideInvalidNameErrorMessage();
        SetNickName();
    }

    private void SetNickName()
    {
        NickNameChanger.ChangeNickName(nickNameIF.text.ToLower(), ChangePage, ShowInvalidNameErrorMessage);
    }
    private void ChangePage()
    {
        navigationPage.PushPage(nextPage);
    }
    private void HideInvalidNameErrorMessage()
    {
        invalidNameErrorMessage.SetActive(false);
    }
    private void ShowInvalidNameErrorMessage()
    {
        //invalidNameErrorMessage.SetActive(true);
    }
}
