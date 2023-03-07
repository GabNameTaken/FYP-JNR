using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UseItem : InteractableObject
{
    public string itemToUse;
    [SerializeField]
    private string textBefore, textAfter;
    [SerializeField]
    private GameObject itemToSpawn;
    private GameObject popupNotif;

    void Start()
    {
        popupNotif = GameObject.FindWithTag("PopupNotif");
    }

    private void ClearText()
    {
        popupNotif.GetComponent<TMP_Text>().text = "";
    }
    private void EnablePopup()
    {

    }

    public override void OnClick()
    {
        if (ItemButton.selectedItem == itemToUse)
        {
            if (textAfter != null)
                popupNotif.GetComponent<TMP_Text>().text = textAfter;
            CInventoryItemButtons.instance.onRemoveInventoryCItem(itemToUse);
            Invoke("ClearText", 1f);
            if (gameObject.GetComponent<PopupItems>() != null)
                gameObject.GetComponent<PopupItems>().enabled = true;
            else if (itemToSpawn != null)
                itemToSpawn.SetActive(true);
            Destroy(this, 1f);
        }
        else
        {
            if (textBefore != null)
                popupNotif.GetComponent<TMP_Text>().text = textBefore;
            Invoke("ClearText", 1f);
        }
    }
}
