using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CInventoryItemButtons : MonoSingletonTemplate<CInventoryItemButtons>
{
    [SerializeField] private GameObject inv;

    private void Awake()
    {
        InitializeSingleton(this);
    }
    public void onAddInventoryCItem(CItem item)
    {
        GameObject go = Instantiate(inv, gameObject.transform);
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
