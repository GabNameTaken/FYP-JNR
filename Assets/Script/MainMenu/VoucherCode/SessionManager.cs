using Photon.Pun;
using System;
using UnityEngine.Networking;
using UnityEngine;

public class SessionManager : MonoBehaviourPunCallbacks
{
    [SerializeField] bool UseSITWebServiceAPI;
    [SerializeField] SessionInfo sessionInfo;

    public delegate void OnJoinedSessionSuccess();
    public OnJoinedSessionSuccess onJoinedSessionSuccess;

    public delegate void OnJoinedSessionInvalidFail(int statusCode);
    public OnJoinedSessionInvalidFail onJoinedSessionInvalidFail;

    public delegate void OnJoinedSessionRequestFail(UnityWebRequest.Result result);
    public OnJoinedSessionRequestFail onJoinedSessionRequestFail;

    //SessionInfo sessionInfo;

    public override void OnEnable()
    {
        base.OnEnable();

        SITWebServiceAPI.onVerifyVoucherSuccess += CheckVoucherStatus;
        SITWebServiceAPI.onVerifyVoucherFail += CallFailEvent;
    }
    public override void OnDisable()
    {
        base.OnDisable();

        SITWebServiceAPI.onVerifyVoucherSuccess -= CheckVoucherStatus;
        SITWebServiceAPI.onVerifyVoucherFail -= CallFailEvent;
    }

    private void CheckVoucherStatus(string voucherCode, VoucherData voucherData)
    {
        switch(voucherData.voucherStatusCode)
        {
            case SITWebServiceAPI.PLAYABLE_VOUCHER_CODE:

                sessionInfo.StoreVoucherData(voucherCode, voucherData);
                SessionCreator.JoinLobby(sessionInfo);

                break;

            case SITWebServiceAPI.INVALID_VOUCHER_CODE:
                // fallthru to default
            case SITWebServiceAPI.NOT_DUE_VOUCHER_CODE:
            case SITWebServiceAPI.EXPIRED_VOUCHER_CODE:
            default:
                onJoinedSessionInvalidFail?.Invoke(voucherData.voucherStatusCode);
                break;
        }
    }

    private void CallFailEvent(UnityWebRequest.Result result)
    {
        onJoinedSessionRequestFail?.Invoke(result);
    }


    public override void OnJoinedLobby()
    {
        onJoinedSessionSuccess?.Invoke();
    }


    public void SubmitVoucherCode(string voucherCode)
    {
        if (PhotonNetwork.OfflineMode)
            OnJoinedLobby();
        else
        {
            if (UseSITWebServiceAPI)
            {
                SITWebServiceAPI.instance.VerifyVoucher(voucherCode);
            }
            else
            {
                Debug.Log("NOT USING SIT WEB SERVICE API");

                if (voucherCode == "V001")
                {
                    VoucherData voucherData = new();
                    voucherData.maxPlayers = 100;
                    voucherData.gameDuration = 90;
                    voucherData.voucherDuration = 360;
                    sessionInfo.StoreVoucherData(voucherCode, voucherData);
                    SessionCreator.JoinLobby(sessionInfo);
                }
                else if (voucherCode == "V002")
                {
                    onJoinedSessionInvalidFail?.Invoke(2);
                }
                else if (voucherCode == "V003")
                {
                    onJoinedSessionInvalidFail?.Invoke(3);
                }
                else
                {
                    onJoinedSessionInvalidFail?.Invoke(99);
                }
            }
        }
    }


    public void RejoinSession()
    {
        SessionCreator.JoinLobby(sessionInfo);
    }
    public int GetMaxPlayers()
    {
        return sessionInfo == null ? 0 : sessionInfo.MaxPlayers;
    }
    public SessionInfo GetSessionInfo()
    {
        return sessionInfo;
    }
}
