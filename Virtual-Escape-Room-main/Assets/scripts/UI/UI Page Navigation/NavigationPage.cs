using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using System.Collections;

[System.Serializable]
public class NavigationEvent : UnityEvent<VideoBackgroundPage>
{
}
public class NavigationPage : MonoBehaviour
{
    [SerializeField] VideoBackgroundPage rootPage;

    [SerializeField] NavigationEvent Pushed;
    [SerializeField] NavigationEvent Popped;
    [SerializeField] UnityEvent PoppedToRoot;

    private Stack<VideoBackgroundPage> ContentStack;

    public void Awake()
    {
        ContentStack = new Stack<VideoBackgroundPage>();
        ContentStack.Push(rootPage);
        StartCoroutine(rootPage.TransitionIn());
    }

    public void PushPage(VideoBackgroundPage page)
    {
        StartCoroutine(TransitionPage(page, ContentStack.Peek()));

        ContentStack.Push(page);

        Pushed?.Invoke(page);

        PrintStack();
    }

    public void PopPage()
    {
        if (ContentStack.Count != 1)
        {
            VideoBackgroundPage poppedPage = ContentStack.Pop();

            StartCoroutine(TransitionPage(ContentStack.Peek(), poppedPage));

            Popped?.Invoke(poppedPage);

            if (ContentStack.Count == 1)
            {
                PoppedToRoot?.Invoke();
            }

            PrintStack();
        }
    }

    IEnumerator TransitionPage(VideoBackgroundPage pageIn, VideoBackgroundPage pageOut)
    {
        StartCoroutine(pageOut.TransitionOut());

        yield return new WaitWhile(() => pageOut.IsTransitioning);

        StartCoroutine(pageIn.TransitionIn());
    }

    private void PrintStack()
    {
        Debug.Log("Stack size: " + ContentStack.Count + ", Top: " + ContentStack.Peek().name);
    }
}
