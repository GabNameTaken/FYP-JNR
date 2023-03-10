using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionPClicked : MonoBehaviour
{
    [SerializeField] GameObject pcScreen, roomItems;
    [SerializeField] GameObject[] otherGOs;

    public void SetPCScreenToActive()
    {
        pcScreen.SetActive(true);
        roomItems.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
    }

    public void close()
    {
        pcScreen.SetActive(false);
        roomItems.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
