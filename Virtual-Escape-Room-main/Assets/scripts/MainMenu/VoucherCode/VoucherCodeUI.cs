using UnityEngine;
using TMPro;

public class VoucherCodeUI : MonoBehaviour
{ 
    [SerializeField] TMP_InputField voucherCodeIF;

    [SerializeField] GameObject invalidCodeErrorMessage;

    [SerializeField] NavigationPage navigationPage;
    [SerializeField] VideoBackgroundPage nickNamePage;

    [SerializeField] SessionManager sessionManager;

    private void OnEnable()
    {
        sessionManager.onJoinedSessionSuccess += OnJoinedSessionSuccess;
        sessionManager.onJoinedSessionFail += OnJoinedSessionFail;
    }
    private void OnDisable()
    {
        sessionManager.onJoinedSessionSuccess -= OnJoinedSessionSuccess;
        sessionManager.onJoinedSessionFail -= OnJoinedSessionFail;
    }

    private void OnJoinedSessionSuccess()
    {
        ChangePage();
    }
    private void OnJoinedSessionFail()
    {
        DIsplayInvalidCodeErrorMessage();
    }


    public void OnTryJoinSession()
    {
        HideInvalidCodeErrorMessage();
        CheckVoucherCode();
    }


    private void CheckVoucherCode()
    {
        sessionManager.SubmitVoucherCode(voucherCodeIF.text.ToUpper());
    }
    private void HideInvalidCodeErrorMessage()
    {
        invalidCodeErrorMessage.SetActive(false);
    }
    private void DIsplayInvalidCodeErrorMessage()
    {
        invalidCodeErrorMessage.SetActive(true);
    }
    private void ChangePage()
    {
        navigationPage.PushPage(nickNamePage);
    }
}
