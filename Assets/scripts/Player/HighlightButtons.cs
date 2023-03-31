using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightButtons : MonoBehaviour
{
    private Button button;
    public Color selectedColor;
    private Color originalColor;
    private ColorBlock colorBlock;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        colorBlock = button.colors;
        originalColor = colorBlock.normalColor;
    }

    public void ChangeUponHover()
    {
        colorBlock.normalColor = selectedColor;
        button.colors = colorBlock;
    }

    public void RevertColor()
    {
        colorBlock.normalColor = originalColor;
        button.colors = colorBlock;
    }
}
