using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    [SerializeField] private Sprite[] img;
    [SerializeField] private GameObject image, screwdriver, note;
    private GameObject player;

    Hints hints;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        hints = FindObjectOfType<Hints>();
    }

    void Update()
    {
        
    }

    public void ItemsPickedUp()
    {
        image.GetComponent<Image>().sprite = img[1];
        player.GetComponent<SyncInventory>().CallPickupItem("Screwdriver");

        hints.CompletedPuzzle();
    }

    public void BookPickup()
    {
        player.GetComponent<SyncInventory>().CallPickupItem("Morse Book");
    }
}
