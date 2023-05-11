using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CCameraControls : MonoBehaviourPun
{
    [SerializeField] ObjectInspector previewObj;
    [SerializeField] GameObject player;

    private float yaw, pitch;
    private float startYaw, startPitch;

    private void Awake()
    {
        startYaw = 0 + Input.GetAxis("Mouse X");
        startPitch = 0 + Input.GetAxis("Mouse Y");
        yaw = startYaw;
        pitch = startPitch;
        List<Canvas> canvases = new();
        canvases.AddRange(FindObjectsOfType<Canvas>(true));
        foreach (Canvas canvas in canvases)
        {
            if (canvas.transform.tag == "CameraCanvas")
            {
                canvas.worldCamera = GetComponent<Camera>();
            }
        }
    }

    private void Update()   
    {
        //looking
        if (!previewObj.IsViewing && player.GetComponent<PhotonView>().IsMine)
        {
            if (Input.GetMouseButton(1))
            {
                yaw -= 2.0f * Input.GetAxis("Mouse X");
                pitch = Mathf.Clamp(pitch + 2.0f * Input.GetAxis("Mouse Y"), -85, 85);
                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }
    }
}
