using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Canvas popupCanvas;
    private Camera playerCam;
    private Quaternion originalRot;

    public void GetPlayerCam(Camera cam)
    {
        popupCanvas.worldCamera = cam;
        playerCam = cam;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
