using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CInventoryItemButtons : MonoSingletonTemplate<CInventoryItemButtons>
{
    [SerializeField] private GameObject inv;
    [SerializeField] private GameObject inventoryContent;
    private void Awake()
    {
        InitializeSingleton(this);
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void onAddInventoryCItem(CItem item)
    {
        GameObject go = Instantiate(inv, inventoryContent.transform);
        ItemButton button = go.GetComponent<ItemButton>();
        button.AddItemButton(item);
    }

    public void onRemoveInventoryCItem(string itemUsed)
    {
        foreach (ItemButton itemButton in gameObject.GetComponentsInChildren<ItemButton>())
        {
            itemButton.CheckAndRemoveButton(itemUsed);
        }
    }
}
