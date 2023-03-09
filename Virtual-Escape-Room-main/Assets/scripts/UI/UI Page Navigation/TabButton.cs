using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using TMPro;

namespace VirtualEscapeRoom.UI
{
    public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        [SerializeField] TabGroup tabGroup;

        [SerializeField] Image background;
        [SerializeField] bool isChangingBackgroundImage;
        [SerializeField] bool isChangingBackgroundColour;
        [SerializeField] TextMeshProUGUI textMeshProUGUI;
        [SerializeField] bool isChangingTextColour;

        [SerializeField] UnityEvent OnSelect;
        [SerializeField] UnityEvent OnDeselect;


        public Sprite BackgroundImage 
        { 
            set
            {
                if (isChangingBackgroundImage) background.sprite = value;
            }
        }
        public Color Colour
        {
            set
            {
                if (isChangingBackgroundColour) background.color = value;
                if (isChangingTextColour) textMeshProUGUI.color = value;
            }
        }

        private void Start()
        {
            tabGroup.Subscribe(this);
        }

        public void InvokeOnSelect()
        {
            OnSelect?.Invoke();
        }

        public void InvokeOnDeselect()
        {
            OnDeselect?.Invoke();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            tabGroup.OnTabSelect(this);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            tabGroup.OnTabEnter(this);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tabGroup.OnTabExit(this);
        }
    }
}