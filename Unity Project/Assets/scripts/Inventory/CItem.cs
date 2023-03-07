using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CItem : MonoBehaviour
{
    private bool bIsInspectable;
    private bool bIsPickedUp;
    [SerializeField] private bool bIsRotatable;

    [SerializeField] private string strItemName;
    [SerializeField] private Sprite previewSprite;
    //add private refference to the model so we can inspect later
    [SerializeField] private GameObject previewObject;
    [SerializeField] private string itemDescription;
    [SerializeField] Vector3 V3Normal;
    [SerializeField] Vector3 V3Up;

    public Vector3 getV3Up() { return V3Up; }
    public void setbIsInspectable(bool toSet) { bIsInspectable = toSet; }
    public void setbIsPickedUp(bool toSet) { bIsPickedUp = toSet; }
    public bool getbIsInspectable() { return bIsInspectable; }
    public bool getbIsPickedUp() { return bIsPickedUp; }
    public bool getbIsRotatable() { return bIsRotatable; }

    public string getItemDescription() {return itemDescription; }

    public string getstrItemName() { return strItemName; }
    public string getGameObjectName() { return gameObject.name; }
    public Sprite getpreviewSprite() { return previewSprite; }
    public GameObject getPreviewGameObject() { return previewObject; }

    public Vector3 getV3Normal() { return V3Normal; }
}
