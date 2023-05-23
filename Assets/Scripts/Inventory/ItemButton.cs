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
    private ObjectInspectorUI objectInspectorUI;

    public static string selectedItem;

    private void Awake()
    {
        objectInspectorUI = FindObjectOfType<ObjectInspectorUI>();
    }

    public void OnSelect(BaseEventData eventData)
    {
        if (selectedItem != item.gameObject.name)
        {
            selectedItem = item.gameObject.name;
        }
    }

    public void OnClick_InspectItem()
    {
        foreach (Transform child in item.gameObject.transform)
        {
            child.gameObject.layer = LayerMask.NameToLayer("Inspect");
        }
        objectInspectorUI.InspectItem(item.gameObject);
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
