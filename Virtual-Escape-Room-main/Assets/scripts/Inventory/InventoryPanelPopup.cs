using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryPanelPopup : MonoBehaviour
{
    [SerializeField] RectTransform panelRTransform;
    [SerializeField] RectTransform InventoryControlPanel;
    [SerializeField] RectTransform Item3DInspectorPanel;

    ObjectInspector objectInspector;

    bool isInventoryOpened;

    public void SetInspectorToControl(ObjectInspector objectInspector)
    {
        this.objectInspector = objectInspector;
    }

    #region Buttons

    public void OnClickInventory()
    {
        if (isInventoryOpened)
        {
            HideInventoryPanel();
            isInventoryOpened = false;
        }
        else
        {
            ShowInventoryPanel();
            isInventoryOpened = true;
        }
    }

    public void OnClickViewDescription()
    {
        objectInspector?.ViewDescription();
    }

    public void OnClickInspect3DItem()
    {
        objectInspector?.Inspect3DItem();
        ShowInspect3DObjectPanel();
    }

    public void OnClickStopInspecting3DItem()
    {
        objectInspector?.StopInspecting3DItem();
        ShowInventoryControlPanel();
    }

    public void OnClickReset3DInspectCamera()
    {
        objectInspector?.Reset3DInspectCamera();
    }

    public void OnClickZoomIn3DCamera()
    {
        objectInspector?.ZoomIn3DCamera();
    }

    public void OnClickZoomOut3DCamera()
    {
        objectInspector?.ZoomOut3DCamera();
    }

    #endregion

    private void ShowInventoryPanel()
    {
        ShowInventoryControlPanel();
        panelRTransform.offsetMin += new Vector2(0, 173);
        panelRTransform.offsetMax += new Vector2(0, 173);
    }
    private void HideInventoryPanel()
    {
        panelRTransform.offsetMin -= new Vector2(0, 173);
        panelRTransform.offsetMax -= new Vector2(0, 173);
    }
    private void ShowInventoryControlPanel()
    {
        InventoryControlPanel.gameObject.SetActive(true);
        Item3DInspectorPanel.gameObject.SetActive(false);
    }
    private void ShowInspect3DObjectPanel()
    {
        Item3DInspectorPanel.gameObject.SetActive(true);
        InventoryControlPanel.gameObject.SetActive(false);
    }
}
