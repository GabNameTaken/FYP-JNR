using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour
{
    [SerializeField] GameObject canvas, roomItems;
    [SerializeField] GameObject[] otherGOs;

    public void SetCanvasToActive()
    {
        canvas.SetActive(true);
        roomItems.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
    }

    public void Close()
    {
        canvas.SetActive(false);
        roomItems.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
