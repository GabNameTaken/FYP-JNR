using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncObject : MonoBehaviour
{
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
            gameObject.SetActive(false);
    }
}
