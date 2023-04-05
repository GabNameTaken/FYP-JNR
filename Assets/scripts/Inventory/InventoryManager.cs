using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoSingletonTemplate<InventoryManager>
{
    [SerializeField] private GameObject button;
    [SerializeField] GameObject inventoryPanel;
    private GameObject inventory;

    private void Awake()
    {
        InitializeSingleton(this);
        inventory = inventoryPanel.transform.Find("Inventory ScrollView").GetChild(0).GetChild(0).gameObject;
    }

    public void onAddInventoryCItem(CItem item)
    {
        GameObject go = Instantiate(button, inventory.transform);
        ItemButton itemButton = go.GetComponent<ItemButton>();
        itemButton.AddItemButton(item);
    }

    public void onRemoveInventoryCItem(string itemUsed)
    {
        foreach (ItemButton itemButton in gameObject.GetComponentsInChildren<ItemButton>())
        {
            itemButton.CheckAndRemoveButton(itemUsed);
        }
    }
}
