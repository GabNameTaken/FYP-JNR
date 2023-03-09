using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour, ISelectHandler
{
    [SerializeField]
    private Image itemImage;
    private CItem item;

    public static string selectedItem;
    void Start()
    {

    }

    public void OnSelect(BaseEventData eventData)
    {
        if (selectedItem != item.gameObject.name)
        {
            selectedItem = item.gameObject.name;
        }
        Debug.Log(selectedItem);
    }

    public void AddItemButton(CItem item)
    {
        this.item = item;
        itemImage.sprite = item.getpreviewSprite();
    }

    public void CheckAndRemoveButton(string itemUsed)
    {
        if (itemUsed == gameObject.name)
        {
            Destroy(gameObject);
        }
    }
}
