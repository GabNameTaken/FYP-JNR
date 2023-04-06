using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteOnHover : MonoBehaviour
{
    private Button button;
    public Sprite selectedSprite;
    private Sprite originalSprite;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        originalSprite = button.image.sprite;
    }

    public void ChangeSprite()
    {
        button.image.sprite = selectedSprite;
    }

    public void RestoreSprite()
    {
        button.image.sprite = originalSprite;
    }
}
