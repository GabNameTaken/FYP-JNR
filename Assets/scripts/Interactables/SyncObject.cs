using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SyncObject : MonoBehaviour
{
    private GameObject itemHolder;

    private void Awake()
    {
        itemHolder = GameObject.FindWithTag("ItemHolder");
    }
    //public GameObject FindGameObject()
    //{
        
    //    return;
    //}
    [PunRPC]
    public void ActiveObject(bool active)
    {
        CInventoryItemButtons.instance.onAddInventoryCItem(gameObject.GetComponent<CItem>());
        gameObject.SetActive(active);
    }
}
