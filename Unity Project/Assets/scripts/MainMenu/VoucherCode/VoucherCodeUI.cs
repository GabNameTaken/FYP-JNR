using UnityEngine;
using TMPro;
using System;
using System.Collections;

public class VoucherCodeUI : MonoBehaviour
{
    [SerializeField] string VOUCHER_NOT_DUE_MESSAGE;
    [SerializeField] string VOUCHER_EXPIRED_MESSAGE;
    [SerializeField] string VOUCHER_INVALID_MESSAGE;
                     
    [SerializeField] string REQUEST_ERROR_MESSAGE;

    [Space]

    [SerializeField] TMP_InputField voucherCodeIF;

    [SerializeField] TextMeshProUGUI invalidCodeErrorMessage;
    [SerializeField] CanvasGroup invalidCodeErrorMessageCanvasGroup;

    [SerializeField] NavigationPage navigationPage;
    [SerializeField] VideoBackgroundPage nickNamePage;

    [SerializeField] SessionManager sessionManager;
    [SerializeField] ModalWindow modalWindow;

    private void OnEnable()
    {
        HideInvalidCodeErrorMessage();

        voucherCodeIF.text = string.Empty;

        sessionManager.onJoinedSessionSuccess += OnJoinedSessionSuccess;
        sessionManager.onJoinedSessionInvalidFail += OnJoinedSessionInvalidFail;
        sessionManager.onJoinedSessionRequestFail += OnJoinedSessionRequestFail;
    }

    private void OnDisable()
    {
        sessionManager.onJoinedSessionSuccess -= OnJoinedSessionSuccess;
        sessionManager.onJoinedSessionInvalidFail -= OnJoinedSessionInvalidFail;
        sessionManager.onJoinedSessionRequestFail -= OnJoinedSessionRequestFail;
    }

    private void OnJoinedSessionSuccess()
    {
        ChangePage();
    }
    private void OnJoinedSessionInvalidFail(int statusCode)
    {
        switch (statusCode)
        {
            case SITWebServiceAPI.NOT_DUE_VOUCHER_CODE:
                modalWindow.InitialiseWindow();
                modalWindow.SetPanelAlpha(.5f);
                modalWindow.SetHeaderText("Voucher not due.");
                modalWindow.SetMessage(VOUCHER_NOT_DUE_MESSAGE);
                modalWindow.SetButton("Back", null);
                break;
            case SITWebServiceAPI.EXPIRED_VOUCHER_CODE:
                modalWindow.InitialiseWindow();
                modalWindow.SetPanelAlpha(.5f);
                modalWindow.SetHeaderText("Voucher expired.");
                modalWindow.SetMessage(VOUCHER_EXPIRED_MESSAGE);
                modalWindow.SetButton("Back", null);
                break;

            case SITWebServiceAPI.INVALID_VOUCHER_CODE:
                invalidCodeErrorMessage.text = VOUCHER_INVALID_MESSAGE;
                DIsplayInvalidCodeErrorMessage();
                break;
            default:
                break;
        }
    }
    private void OnJoinedSessionRequestFail(UnityEngine.Networking.UnityWebRequest.Result result)
    {
        invalidCodeErrorMessage.text = "Error type: " + result.ToString() + ". " + REQUEST_ERROR_MESSAGE;
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
    private void ChangePage()
    {
        navigationPage.PushPage(nickNamePage);
    }
    private void HideInvalidCodeErrorMessage()
    {
        invalidCodeErrorMessageCanvasGroup.alpha = 0;
    }
    private void DIsplayInvalidCodeErrorMessage()
    {
        StartCoroutine(ErrorMessageTransitionIn());
    }
    IEnumerator ErrorMessageTransitionIn()
    {
        invalidCodeErrorMessageCanvasGroup.alpha = 1;
        yield return new WaitForSeconds(.1f);
        invalidCodeErrorMessageCanvasGroup.alpha = 0;
        yield return new WaitForSeconds(.1f);
        invalidCodeErrorMessageCanvasGroup.alpha = 1;
    }
}
