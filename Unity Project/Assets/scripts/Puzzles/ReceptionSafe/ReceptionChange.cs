using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionChange : MonoBehaviour
{
    public Material[] material;
    private bool open = false;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            rend.sharedMaterial = material[1];
        }
    }

    public void UpdateReceptionSkybox(bool b)
    {
        open = b;
    }
}
