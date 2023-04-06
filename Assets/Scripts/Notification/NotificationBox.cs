using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class NotificationBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI message;
    [SerializeField] Image image;
    [SerializeField] GameObject imageObject;
    [SerializeField] RectTransform rectTransform;  

    [Space]

    [SerializeField] float transitionTimeSeconds;

    float transitionInTime = 0;
    float lifeTime = 0;
    float transitionOutTime = 0;

    float HiddenXPosition { get => Screen.width + rectTransform.rect.width; }
    float ActiveXPosition { get => Screen.width; }

    public void Initialise(float decayTime)
    {
        imageObject.SetActive(false);

        SetTransitionTime(decayTime);

        lifeTime = decayTime - (transitionTimeSeconds * 2);

        Debug.Log("Init");

        StartCoroutine(TransitionIn());
    }
    public void SetTitle(string title)
    {
        this.title.text = title;
    }
    public void SetMessage(string message)
    {
        this.message.text = message;
    }
    public void SetImageSprite(Sprite imageSprite)
    {
        if (imageSprite != null)
        {
            image.sprite = imageSprite;
            imageObject.SetActive(true);
        }
    }


    private void SetTransitionTime(float decayTime)
    {
        if (decayTime < transitionTimeSeconds * 2)
        {
            transitionInTime = 0;
            transitionOutTime = decayTime;
        }
        else
        {
            transitionOutTime = transitionInTime = transitionTimeSeconds;
        }
    }

    IEnumerator TransitionIn()
    {
        rectTransform.position = new Vector3(HiddenXPosition, rectTransform.position.y, rectTransform.position.z);
        rectTransform.DOMoveX(ActiveXPosition, transitionInTime);

        yield return new WaitForSeconds(transitionInTime);

        StartCoroutine(CountDownLifeTime());
    }
    IEnumerator CountDownLifeTime()
    {
        yield return new WaitForSeconds(lifeTime);

        StartCoroutine(TransitionOut());
    }
    IEnumerator TransitionOut()
    {
        rectTransform.DOMoveX(HiddenXPosition, transitionOutTime);

        yield return new WaitForSeconds(transitionOutTime);

        gameObject.SetActive(false);
    }
}
