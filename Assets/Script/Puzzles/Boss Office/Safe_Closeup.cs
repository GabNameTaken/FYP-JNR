using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe_Closeup : InteractableObject
{
    [SerializeField] GameObject safe_canvas, roomItems;
    [SerializeField] GameObject[] otherGOs;

    public override void OnClick()
    {
        safe_canvas.SetActive(true);
        roomItems.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
    }
    public void close()
    {
        safe_canvas.SetActive(false);
        roomItems.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
