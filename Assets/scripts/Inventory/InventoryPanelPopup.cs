using UnityEngine;

public class InventoryPanelPopup : MonoBehaviour
{
    [SerializeField] RectTransform panelRTransform;
    [SerializeField] GameObject openedPanel;
    [SerializeField] GameObject closedPanel;

    bool isInventoryOpened;


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

    #endregion

    private void ShowInventoryPanel()
    {
        openedPanel.SetActive(true);
        closedPanel.SetActive(false);

        panelRTransform.offsetMin += new Vector2(0, 173);
        panelRTransform.offsetMax += new Vector2(0, 173);
    }
    private void HideInventoryPanel()
    {
        openedPanel.SetActive(false);
        closedPanel.SetActive(true);

        panelRTransform.offsetMin -= new Vector2(0, 173);
        panelRTransform.offsetMax -= new Vector2(0, 173);
    }
}
