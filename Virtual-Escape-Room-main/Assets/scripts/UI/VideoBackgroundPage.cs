using System.Collections;
using UnityEngine;

public class VideoBackgroundPage : MonoBehaviour
{
    [Header("Video Background")]
    [SerializeField] VideoAssetFilePath videoAssetFilePath;
    [SerializeField] GameObject content;
    [SerializeField] CanvasGroup canvasGroup;
    [Space]
    private bool isTransitioning = false;
    public bool IsTransitioning { get => isTransitioning; }
    public VideoAssetFilePath VideoAssetFilePath { get => videoAssetFilePath; }

    public IEnumerator TransitionIn()
    {
        SetContentActive(true);
        canvasGroup.alpha = 0;
        yield return new WaitForSeconds(.5f);
        canvasGroup.alpha = 1;
        yield return new WaitForSeconds(.1f);
        canvasGroup.alpha = 0;
        yield return new WaitForSeconds(.1f);
        canvasGroup.alpha = 1;
    }

    public IEnumerator TransitionOut()
    {
        canvasGroup.alpha = 0;
        yield return new WaitForSeconds(.1f);
        canvasGroup.alpha = 1;
        yield return new WaitForSeconds(.1f);
        SetContentActive(false);
    }

    private void SetContentActive(bool active)
    {
        if (content)
            content.SetActive(active);
    }
}
