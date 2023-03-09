using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionPClicked : MonoBehaviour
{
    [SerializeField] GameObject pcScreen;

    public void SetPCScreenToActive()
    {
        pcScreen.SetActive(true);
    }
}
