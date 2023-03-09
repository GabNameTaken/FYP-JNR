using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CCameraControls : MonoBehaviourPun
{
    [SerializeField] ObjectInspector previewObj;

    private float yaw, pitch;
    private float startYaw, startPitch;

    private void Awake()
    {
        startYaw = 0 + Input.GetAxis("Mouse X");
        startPitch = 0 + Input.GetAxis("Mouse Y");
        yaw = startYaw;
        pitch = startPitch;
    }

    private void Update()   
    {
        //looking
        if (!previewObj.IsViewing)
        {
            if (Input.GetMouseButton(0))
            {
                yaw -= 2.0f * Input.GetAxis("Mouse X");
                pitch = Mathf.Clamp(pitch + 2.0f * Input.GetAxis("Mouse Y"), -85, 85);
                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }
    }
}
