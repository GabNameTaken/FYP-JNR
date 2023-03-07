using System;
using UnityEngine;
using TMPro;

public class ObjectInspectorUI : MonoBehaviour, IObjectInspectorHandler
{
    [SerializeField] GameObject inspectWindow;
    [SerializeField] TextMeshProUGUI descriptionText;

    ObjectInspector objectInspector;
    GameObject target;

    public void SetInspectorReference(ObjectInspector objectInspector)
    {
        this.objectInspector = objectInspector;
    }

    public void InspectItem(GameObject item)
    {
        if (IsInspecting())
        {
            objectInspector.StopInspecting3DItem();
        }
        inspectWindow.SetActive(true);
        target = item;
        objectInspector.SetTarget(target);
        objectInspector.Inspect3DItem();

        SetDescriptionText();
    }

    public void StopInspecting()
    {
        inspectWindow.SetActive(false);
        target = null;
        objectInspector.StopInspecting3DItem();
    }

    private bool IsInspecting()
    {
        return target;
    }

    private void SetDescriptionText()
    {
        descriptionText.text = "Description : \n" + target.GetComponent<CItem>().getItemDescription();
    }
}
