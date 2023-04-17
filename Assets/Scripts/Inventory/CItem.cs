using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CItem : MonoBehaviour
{
    private const int INPSECT_LAYER = 6;
    private bool bIsInspectable;
    private bool bIsPickedUp;

    //  Variables for inspection menu
    public float anchorX = 1.0f;
    public float anchorY = 1.0f;
    public bool constraintToAnchor = false; //Constraint or no constraint for inspection menu

    [SerializeField] private bool bIsRotatable;

    [SerializeField] private string strItemName;
    [SerializeField] private Sprite previewSprite;
    //add private refference to the model so we can inspect later
    [SerializeField] private GameObject previewObject;
    [SerializeField] private string itemDescription;
    [SerializeField] public Vector3 inspectRotation;

    public void setbIsInspectable(bool toSet) { bIsInspectable = toSet; }

    [PunRPC]
    public void setbIsPickedUp(bool toSet) { bIsPickedUp = toSet; }
    public bool getbIsInspectable() { return bIsInspectable; }
    public bool getbIsPickedUp() { return bIsPickedUp; }
    public bool getbIsRotatable() { return bIsRotatable; }

    public string getItemDescription() {return itemDescription; }

    public string getstrItemName() { return strItemName; }
    public string getGameObjectName() { return gameObject.name; }
    public Sprite getpreviewSprite() { return previewSprite; }
    public GameObject getPreviewGameObject() { return previewObject; }

    [PunRPC]
    public void AddToInventory()
    {
        gameObject.SetActive(false);
        setbIsPickedUp(true);
        previewObject.layer = INPSECT_LAYER;
        CInventoryItemButtons.instance.onAddInventoryCItem(gameObject.GetComponent<CItem>());
    }
}
