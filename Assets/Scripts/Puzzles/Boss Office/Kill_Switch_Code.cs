using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class Kill_Switch_Code : MonoBehaviour
{
    [SerializeField] TMP_InputField input_field;
    [SerializeField] GameObject blackScreen, parent_canvas, liftNavigation;

    public string decrypted_code;

    public void check_code()
    {
        if (input_field.text.ToUpper() == decrypted_code)
        {
            // Game Ending stuff here
            Debug.Log("ESCAPE ROOM COMPLETED!");
            parent_canvas.SetActive(false);
            blackScreen.SetActive(true);
            PhotonView photonView = GetComponent<PhotonView>();
            photonView.RPC("UnlockLift", RpcTarget.AllViaServer);
        }
    }

    [PunRPC]
    public void UnlockLift()
    {
        liftNavigation.SetActive(true);
        QueuedNotification.NotificationInfo notificationInfo = new();
        notificationInfo.title = "Objective: ";
        notificationInfo.message = "Repair the lift";
        notificationInfo.durationSeconds = 5;
        QueuedNotification.instance.QueueNotification(notificationInfo);
    }
}
