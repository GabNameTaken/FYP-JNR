using UnityEngine;

public class InventoryPanelPopup : MonoBehaviour
{
    [SerializeField] RectTransform button;
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

        button.position = new Vector3(button.position.x, button.position.y +  225, button.position.z);
    }
    private void HideInventoryPanel()
    {
        openedPanel.SetActive(false);
        closedPanel.SetActive(true);

        button.position = new Vector3(button.position.x, button.position.y - 225, button.position.z);
    }
}
