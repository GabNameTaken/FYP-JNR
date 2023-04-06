using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class SITWebServiceAPI : MonoSingletonTemplate<SITWebServiceAPI>
{
    const string VERIFY_VOUCHER_URI = "https://lbm1fb9c1j.execute-api.ap-southeast-1.amazonaws.com/staging/verifyVoucher";
    const string START_GAME_URI = "https://lbm1fb9c1j.execute-api.ap-southeast-1.amazonaws.com/staging/startGame";
    const string END_GAME_URI = "https://lbm1fb9c1j.execute-api.ap-southeast-1.amazonaws.com/staging/endGame";

    const string API_KEY = "AFGG2piXh0ht6dmX";

    public const int INVALID_VOUCHER_CODE = 99;
    public const int PLAYABLE_VOUCHER_CODE = 1;
    public const int NOT_DUE_VOUCHER_CODE = 2;
    public const int EXPIRED_VOUCHER_CODE = 3;


    public delegate void OnVerifyVoucherSuccess(string voucherCode, VoucherData voucherData);
    public static OnVerifyVoucherSuccess onVerifyVoucherSuccess;

    public delegate void OnVerifyVoucherFail(UnityWebRequest.Result result);
    public static OnVerifyVoucherFail onVerifyVoucherFail;

    private void Awake()
    {
        InitializeSingleton(this);
    }

    public void VerifyVoucher(string voucherCode)
    {
        StartCoroutine(SendVerifyVoucherWebRequest(voucherCode));
    }    

    private IEnumerator SendVerifyVoucherWebRequest(string voucherCode)
    {

        UnityWebRequest request = CreateWebRequestWithURIandVoucherCode(VERIFY_VOUCHER_URI, voucherCode);

        yield return request.SendWebRequest();

        switch (request.result)
        {
            case UnityWebRequest.Result.Success:
                DownloadHandler dataResult = request.downloadHandler;
                string json = new System.Text.UTF8Encoding().GetString(dataResult.data);
                VoucherData voucherData = JsonUtility.FromJson<VoucherDataWrapper>(json).data;

                //Debug.Log(json);
                onVerifyVoucherSuccess?.Invoke(voucherCode, voucherData);
                break;

            case UnityWebRequest.Result.ConnectionError:
            // fallthru to default
            case UnityWebRequest.Result.ProtocolError:
            case UnityWebRequest.Result.DataProcessingError:
            default:
                Debug.Log(request.result + ": " + request.GetResponseHeader(""));
                onVerifyVoucherFail?.Invoke(request.result);
                break;
        }
    }

    // Will return {data:{voucherStatusCode: 01}} if valid voucher and 99 if not valid
    private IEnumerator SendStartGameWebRequest(string voucherCode)
    {
        UnityWebRequest request = CreateWebRequestWithURIandVoucherCode(START_GAME_URI, voucherCode);

        yield return request.SendWebRequest();

        switch (request.result)
        {
            case UnityWebRequest.Result.Success:
                DownloadHandler dataResult = request.downloadHandler;
                string json = new System.Text.UTF8Encoding().GetString(dataResult.data);

                Debug.Log(json);
                //VoucherData voucherData = JsonUtility.FromJson<VoucherDataWrapper>(json).data;

                //Debug.Log(voucherData.voucherStatusCode);
                //onVerifyVoucherSuccess?.Invoke(voucherCode, voucherData);
                break;

            case UnityWebRequest.Result.ConnectionError:
            // fallthru to default
            case UnityWebRequest.Result.ProtocolError:
            case UnityWebRequest.Result.DataProcessingError:
            default:
                Debug.Log(request.result + ": " + request.GetResponseHeader(""));
                //onVerifyVoucherFail?.Invoke(request.result);
                break;
        }
    }
    
    // Will return {data:{voucherStatusCode: 01}} if valid voucher and 99 if not valid
    private IEnumerator SendEndGameWebRequest(string voucherCode)
    {
        UnityWebRequest request = CreateWebRequestWithURIandVoucherCode(END_GAME_URI, voucherCode);

        yield return request.SendWebRequest();

        switch (request.result)
        {
            case UnityWebRequest.Result.Success:
                DownloadHandler dataResult = request.downloadHandler;
                string json = new System.Text.UTF8Encoding().GetString(dataResult.data);

                Debug.Log(json);
                //VoucherData voucherData = JsonUtility.FromJson<VoucherDataWrapper>(json).data;

                //Debug.Log(voucherData.voucherStatusCode);
                //onVerifyVoucherSuccess?.Invoke(voucherCode, voucherData);
                break;

            case UnityWebRequest.Result.ConnectionError:
            // fallthru to default
            case UnityWebRequest.Result.ProtocolError:
            case UnityWebRequest.Result.DataProcessingError:
            default:
                Debug.Log(request.result + ": " + request.GetResponseHeader(""));
                //onVerifyVoucherFail?.Invoke(request.result);
                break;
        }
    }

    private UnityWebRequest CreateWebRequestWithURIandVoucherCode(string uri, string voucherCode)
    {
        UnityWebRequest request = new UnityWebRequest(uri, "POST");

        string bodyJsonString = "{\"voucher\":\"" + voucherCode + "\",\"apikey\":\"" + API_KEY + "\"}"; //important

        byte[] data = new System.Text.UTF8Encoding().GetBytes(bodyJsonString);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(data);  // important
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json"); //important

        return request;
    }
}

[System.Serializable]
public class VoucherData
{
    public int voucherStatusCode;
    public int maxPlayers;
    public int gameDuration; // in minutes
    public int voucherDuration; // in minutes
    public string endTime;
}

[System.Serializable]
class VoucherDataWrapper
{
    public VoucherData data;
}