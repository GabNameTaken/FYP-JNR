using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class Take_Kill_Switch : MonoBehaviour
{
    [SerializeField] GameObject kill_switch_GO;
    private GameObject player;
    string inputText;

    public GameObject BG;
    public Texture kill_switch_taken_BG;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void objecttaken()
    {
        kill_switch_GO.SetActive(true);
        player.GetComponent<SyncInventory>().CallPickupItem("Kill Switch");
        BG.GetComponent<RawImage>().texture = kill_switch_taken_BG;
        kill_switch_GO.SetActive(false);
    }
}
