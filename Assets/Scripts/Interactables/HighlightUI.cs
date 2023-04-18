using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightUI : MonoBehaviour
{
    public Image img;
    public Material highlightMaterial;
    public Material material;

    private void Start()
    {
        if (material == null)
            material = img.material;
    }

    public void Highlight()
    {
        img.material = highlightMaterial;
    }

    public void Restore()
    {
        img.material = material;
    }
}
