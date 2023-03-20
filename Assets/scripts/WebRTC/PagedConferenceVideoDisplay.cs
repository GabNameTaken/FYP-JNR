using Byn.Awrtc;
using Byn.Awrtc.Unity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PagedConferenceVideoDisplay : MonoBehaviour, IConferenceVideoOutputHandler
{
    [SerializeField] List<RawImage> rawImages = new();
    [SerializeField] Texture noImgTexture;

    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;

    private readonly List<ConnectionId> idList = new();

    private int currentPage;
    int CurrentPage { get => currentPage; set => currentPage = Mathf.Clamp(value, 1, MaximumPageLength); }
    int SlotsPerPage { get => rawImages.Count; }
    int SmallestIdIndexInView { get => (currentPage - 1) * SlotsPerPage; }
    int LargestIdIndexInView { get => currentPage * SlotsPerPage - 1; }
    int MaximumPageLength { get => Mathf.Max(1, idList.Count / SlotsPerPage); }
    private void OnEnable()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
        CurrentPage = 1;
        UpdateImageSlots();
    }

    public void AddUser(ConnectionId id)
    {
        idList.Add(id);
        UpdateArrows();
        UpdateImageSlots();
    }

    public void RemoveAllUsers()
    {
        idList.Clear();
        CurrentPage = 1;
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
        UpdateImageSlots();
    }

    public void RemoveUser(ConnectionId id)
    {
        if (idList.Contains(id))
        {
            idList.Remove(id);
            CheckPage();
            UpdateArrows();
            UpdateImageSlots();
        }
    }
    private void CheckPage()
    {
        if (CurrentPage > MaximumPageLength)
            CurrentPage = MaximumPageLength;
    }
    private void UpdateArrows()
    {
        leftArrow.SetActive(CurrentPage > 1);
        rightArrow.SetActive(CurrentPage < MaximumPageLength);
    }
    private void UpdateImageSlots()
    {
        for (int i = 0; i < rawImages.Count; i++)
        {
            rawImages[i].gameObject.SetActive(SmallestIdIndexInView + i < idList.Count);
        }   
    }

    public void UpdateFrame(FrameUpdateEventArgs args)
    {
        if (IsIDInView(args.ConnectionId))
        {
            int slotIndex = idList.IndexOf(args.ConnectionId) % SlotsPerPage;

            //make sure not to overwrite / destroy our texture for missing image data
            if (rawImages[slotIndex].texture == noImgTexture)
                rawImages[slotIndex].texture = null;

            bool mirror = args.IsRemote == false;
            //bool mirror = true;
            UnityMediaHelper.UpdateRawImageTransform(rawImages[slotIndex], args.Frame, mirror);

            if (rawImages[slotIndex].texture == null)
                rawImages[slotIndex].texture = noImgTexture;
        }
    }

    private bool IsIDInView(ConnectionId id)
    {
        int idIndex = idList.IndexOf(id);
        return idIndex >= SmallestIdIndexInView && idIndex <= LargestIdIndexInView;
    }

    public void OnPressed_LeftArrow()
    {
        CurrentPage--;
        UpdateImageSlots();
    }
    public void OnPressed_RightArrow()
    {
        CurrentPage++;
        UpdateImageSlots();
    }
}
