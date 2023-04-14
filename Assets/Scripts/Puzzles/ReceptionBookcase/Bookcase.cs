using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookcase : InteractableObject
{
    [SerializeField] GameObject popupBG, roomItems, image, drawerItems, morsebook;
    [SerializeField] GameObject[] otherGOs;
    [SerializeField] Sprite[] img;

    public void PickUpBook()
    {
        image.GetComponent<Image>().sprite = img[1];
    }

    public void ClosePopup()
    {
        popupBG.SetActive(false);
        roomItems.SetActive(true);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(true);
        }
        drawerItems.SetActive(false);
    }

    public override void OnClick()
    {
        popupBG.SetActive(true);
        roomItems.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
        drawerItems.SetActive(true);
        this.gameObject.SetActive(false);
    }

   
}
