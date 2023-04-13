using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextToTextMeshPro : MonoBehaviour
{
    [Header("Updates the text in TextMeshPro to match the text in Legacy text field")]
    [SerializeField] Text text;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    string previousText;

    private void Start()
    {
        text.raycastTarget = false;
        text.color = new Color(0, 0, 0, 0);

        UpdateTextMeshPro();
    }

    private void Update()
    {
        // I cant think of a better way that deosnt use Update
        if (TextHasUpdated())
        {
            UpdateTextMeshPro();
        }
    }

    private bool TextHasUpdated()
    {
        return text.text != previousText;
    }

    private void UpdateTextMeshPro()
    {
        previousText = text.text;
        textMeshProUGUI.text = previousText;
    }
}
