using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hints : MonoBehaviour
{
    [SerializeField] List<string> hintNames;
    [SerializeField] GameObject[] hintObjects;
    [SerializeField] TextMeshProUGUI counter;

    [SerializeField] GameObject Confirmation, NoHints, HintPage;

    [SerializeField] Slider progressBar;

    Dictionary<string, GameObject> hints = new();

    int playerHints = 5;
    bool hintUsed = false;

    void Start()
    {
        counter.text = "You have " + playerHints + " hints left";
        progressBar.value = 0;

        for (int i = 0; i < hintNames.Count; ++i)
        {
            hints.Add(hintNames[i], hintObjects[i]);
        }
        progressBar.maxValue = hints.Count;
    }

    public void HintButtonPress()
    {
        if (playerHints <= 0)
        {
            NoHints.SetActive(true);
        }
        else if (hintUsed == true)
        {
            hints[hintNames[0]].SetActive(true);
            HintPage.SetActive(true);
        }
        else
        {
            Confirmation.SetActive(true);
        }
    }

    public void YesButtonPress()
    {
        Confirmation.SetActive(false);
        playerHints--;
        counter.text = "You have " + playerHints + " hints left";
        hints[hintNames[0]].SetActive(true);
        HintPage.SetActive(true);
    }

    public void CloseHintPress()
    {
        hints[hintNames[0]].SetActive(false);
        HintPage.SetActive(false);
        hintUsed = true;
    }

    public void CompletedPuzzle(string puzzleName)
    {
        hintUsed = false;
        hintNames.Remove(puzzleName);
        StartCoroutine(UpdateProgressBar());
    }

    private IEnumerator UpdateProgressBar()
    {
        float elapsedTime = 0f;

        while (elapsedTime < 1.0f)
        {
            elapsedTime += Time.deltaTime;
            float currentValue = Mathf.FloorToInt(progressBar.value);
            progressBar.value = Mathf.Lerp(currentValue, currentValue + 1, elapsedTime);
            yield return null;
        }
    }
}
