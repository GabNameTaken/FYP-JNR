using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe_Reveal : InteractableObject
{
    [SerializeField] GameObject skybox, safe_GO;

    public bool safe_reveal_status;

    public Texture safe_revealed_skybox;

    private void Start()
    {
        safe_reveal_status = false;
    }

    public override void OnClick()
    {
        if (!safe_reveal_status)
        {
            Debug.Log("Safe found!");
            safe_reveal_status = true;
            skybox.GetComponent<Renderer>().material.mainTexture = safe_revealed_skybox;
            safe_GO.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
