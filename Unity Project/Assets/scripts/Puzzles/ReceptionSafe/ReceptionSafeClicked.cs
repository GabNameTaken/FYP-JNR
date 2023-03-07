using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionSafeClicked : MonoBehaviour
{
    [SerializeField] GameObject Safe, roomObject;
    [SerializeField] GameObject[] otherGOs;

    public void SetSafeToActive()
    {
        Safe.SetActive(true);
        roomObject.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
    }

    public void close()
    {
        Safe.SetActive(false);
        roomObject.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
