using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionSafeClicked : MonoBehaviour
{
    [SerializeField] GameObject Safe;

    public void SetSafeToActive()
    {
        Safe.SetActive(true);
    }
}
