using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerClicked : MonoBehaviour
{

    [SerializeField] GameObject Scanner, roomObject;
    [SerializeField] GameObject[] otherGOs;

    public void SetScannerToActive()
    {
        Scanner.SetActive(true);
        roomObject.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
    }

    public void close()
    {
        Scanner.SetActive(false);
        roomObject.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
    }
}
