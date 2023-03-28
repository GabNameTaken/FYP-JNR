using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharedCamera : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    public void ConnectToCam(Camera connectedCamera)
    {
        cam = connectedCamera;
    }

    public void RectSettings(float x, float y, float width, float height)
    {
        cam.rect = new Rect(x, y, width, height);
    }

    public void setActive(bool active)
    {
        gameObject.SetActive(active);
    }
}
