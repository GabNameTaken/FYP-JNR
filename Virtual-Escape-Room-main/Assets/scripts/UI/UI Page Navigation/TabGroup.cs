using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualEscapeRoom.UI
{
    public class TabGroup : MonoBehaviour
    {
        List<TabButton> tabButtons;

        [SerializeField] Sprite idleBackground;
        [SerializeField] Sprite hoverBackground;
        [SerializeField] Sprite activeBackground;

        [SerializeField] Color idleColour;
        [SerializeField] Color hoverColour;
        [SerializeField] Color activeColour;

        [SerializeField] TabButton selectedTab;

        [SerializeField] List<GameObject> tabPages;
        
        IEnumerator Start()
        {
            // Wait until all buttons have subscribed
            yield return new WaitUntil(() => tabPages.Count == tabButtons?.Count);

            if (selectedTab == null)
                selectedTab = tabButtons[0];

            ResetTabs();
            OnTabSelect(selectedTab);
        }

        public void Subscribe(TabButton tabButton)
        {
            if (tabButtons == null)
            {
                tabButtons = new List<TabButton>();
            }
            tabButtons.Add(tabButton);
        }
        public void OnTabSelect(TabButton tabButton)
        {
            if (selectedTab != null)
            {
                SetTabButtonUIElementsToIdle(selectedTab);
                selectedTab.InvokeOnDeselect();
            }

            selectedTab = tabButton;
            selectedTab.InvokeOnSelect();

            SetTabButtonUIElementsToActive(tabButton);
            ChangePage(tabButton);
        }
        public void OnTabEnter(TabButton tabButton)
        {
            if (tabButton != selectedTab)
            {
                SetTabButtonUIElementsToHover(tabButton);
            }
        }
        public void OnTabExit(TabButton tabButton)
        {
            if (tabButton != selectedTab)
            {
                SetTabButtonUIElementsToIdle(tabButton);
            }
        }

        void ChangePage(TabButton tabButton)
        {
            int index = tabButton.transform.GetSiblingIndex();
            for (int i = 0; i < tabPages.Count; i++)
            {
                tabPages[i].SetActive(i == index);
            }
        }
        void ResetTabs()
        {
            foreach (TabButton tabButton in tabButtons)
            {
                if (tabButton != selectedTab)
                {
                    SetTabButtonUIElementsToIdle(tabButton);
                }
            }
        }
        void SetTabButtonUIElementsToIdle(TabButton tabButton)
        {
            tabButton.BackgroundImage = idleBackground;
            tabButton.Colour = idleColour;
        }
        void SetTabButtonUIElementsToHover(TabButton tabButton)
        {
            tabButton.BackgroundImage = hoverBackground;
            tabButton.Colour = hoverColour;
        }
        void SetTabButtonUIElementsToActive(TabButton tabButton)
        {
            tabButton.BackgroundImage = activeBackground;
            tabButton.Colour = activeColour;
        }
    }
}