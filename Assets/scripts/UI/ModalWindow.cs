using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System.Collections;
/**
* @class ModalWindow
* @brief Customisable Modal Window
* @author Junliang
*/
public class ModalWindow : MonoBehaviour
{
    [SerializeField] private Image image;

    [SerializeField] private GameObject headerGO;

    [SerializeField] private TextMeshProUGUI headerText;
    [SerializeField] private GameObject inputFeildHolderGO;
    [SerializeField] private TMP_InputField inputFeild;
    [SerializeField] private TextMeshProUGUI inputFeildPlaceHolder;

    [SerializeField] private TextMeshProUGUI message;

    [SerializeField] private CanvasGroup contentCanvasGroup;
    [SerializeField] private CanvasGroup panelCanvasGroup;
    [SerializeField] private float defaultPanelAlpha;

    [SerializeField] private Animator animator;

    [Header("Buttons")]

    [SerializeField] ObjectPooler<Button> buttonObjectPool;

    public void Start()
    {
        buttonObjectPool.Initialize();
    }

    public void InitialiseWindow()
    {
        panelCanvasGroup.alpha = defaultPanelAlpha;
        headerGO.SetActive(true);
        message.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        inputFeildHolderGO.gameObject.SetActive(false);

        foreach (GameObject gameObject in buttonObjectPool.gameObjects)
        {
            ObjectPooler<Button>.ReturnGO(gameObject);
        }

        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
            StartCoroutine(TransitionIn());
        }
    }

    IEnumerator TransitionIn()
    {
        contentCanvasGroup.alpha = 0;
        yield return new WaitForSeconds(.4f);
        contentCanvasGroup.alpha = 1;
        yield return new WaitForSeconds(.1f);
        contentCanvasGroup.alpha = 0;
        yield return new WaitForSeconds(.1f);
        contentCanvasGroup.alpha = 1;
    }

    IEnumerator TransitionOut()
    {
        animator.SetBool("Close", true);
        contentCanvasGroup.alpha = 1;
        yield return new WaitForSeconds(.2f);
        contentCanvasGroup.alpha = 0;
        yield return new WaitForSeconds(.1f);
        contentCanvasGroup.alpha = 1;
        yield return new WaitForSeconds(.1f);
        contentCanvasGroup.alpha = 0;
        yield return new WaitForSeconds(.4f);
        gameObject.SetActive(false);
    }

    public void SetPanelAlpha(float alpha)
    {
        panelCanvasGroup.alpha = alpha;
    }
    public void SetMessage(string msg)
    {
        message.gameObject.SetActive(true);
        message.text = msg;
    }

    public void SetButton(string buttonName, UnityAction function, bool hideAfterButtonPress = true)
    {
        Button button = buttonObjectPool.FetchComponent();

        if (hideAfterButtonPress)
            //function += () => windowAnimation.DoTransitionOut();
            function += () => StartCoroutine(TransitionOut());

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(function);
        button.GetComponentInChildren<TextMeshProUGUI>().text = buttonName;
    }

    public void SetImage(Sprite sprite)
    {
        image.gameObject.SetActive(true);
        image.sprite = sprite;
    }

    public void RemoveHeader()
    {
        headerGO.SetActive(false);
    }

    public void SetHeaderText(string text)
    {
        headerText.text = text;
    }

    public void SetInputFeild(string placeholderText = "", int characterLimit = 0)
    {
        inputFeildHolderGO.gameObject.SetActive(true);
        inputFeild.text = string.Empty;
        inputFeildPlaceHolder.text = placeholderText;

        if (characterLimit < 1)
        {
            inputFeild.characterLimit = 0;
        }
        else inputFeild.characterLimit = characterLimit;
    }

    public string GetInputFieldValue()
    {
        return inputFeild.text;
    }
}
