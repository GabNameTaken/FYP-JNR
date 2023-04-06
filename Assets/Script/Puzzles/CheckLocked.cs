using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLocked : MonoBehaviour
{
    private bool Islocked = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStatus(bool i)
    {
        Islocked = i;
    }

    public bool GetStatus()
    {
        return Islocked;
    }
}
