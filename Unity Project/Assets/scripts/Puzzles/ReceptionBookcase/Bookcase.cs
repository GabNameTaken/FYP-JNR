using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bookcase : InteractableObject
{
    [SerializeField] private GameObject popupBG, popupItems, roomItems, image, drawerItems, morsebook;
    [SerializeField] GameObject[] otherGOs;
    [SerializeField] private Sprite[] img;
    //private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    public void PickUpBook()
    {
        //player.GetComponent<SyncInventory>().CallPickupItem("morse");
        image.GetComponent<Image>().sprite = img[1];
        //morsebook.SetActive(true);
    }

    public void ClosePopup()
    {
        popupBG.SetActive(false);
        popupItems.SetActive(false);
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
        popupItems.SetActive(true);
        roomItems.SetActive(false);
        for (int i = 0; i < otherGOs.Length; i++)
        {
            otherGOs[i].SetActive(false);
        }
        drawerItems.SetActive(true);
        this.gameObject.SetActive(false);
    }

   
}
