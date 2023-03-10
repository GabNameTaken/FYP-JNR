using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drawer : MonoBehaviour
{

    [SerializeField] private Sprite[] img;
    [SerializeField] private GameObject image, screwdriver, note;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemsPickedUp()
    {
        image.GetComponent<Image>().sprite = img[1];
        player.GetComponent<SyncInventory>().CallPickupItem("Screwdriver");
        //player.GetComponent<SyncInventory>().CallPickupItem("Note");
        //screwdriver.SetActive(true);
        //note.SetActive(true);
    }

    public void BookPickup()
    {
        player.GetComponent<SyncInventory>().CallPickupItem("morse");
    }
}
