using UnityEngine;

public class InventoryPanelPopup : MonoBehaviour
{
    [SerializeField] GameObject openedPanel;
    [SerializeField] GameObject scrollRect;
    [SerializeField] GameObject closedPanel;

    private void Start()
    {
        openedPanel.SetActive(false);
        scrollRect.SetActive(false);
        closedPanel.SetActive(true);
    }
}
