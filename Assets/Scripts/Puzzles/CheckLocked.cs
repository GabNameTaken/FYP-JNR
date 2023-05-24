using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLocked : MonoBehaviour
{
    private bool Islocked = true;
    public void SetStatus(bool i)
    {
        Islocked = i;
    }

    public bool GetStatus()
    {
        return Islocked;
    }
}
