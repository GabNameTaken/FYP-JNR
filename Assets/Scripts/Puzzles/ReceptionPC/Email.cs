using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Email : MonoBehaviour
{
    [SerializeField] Image img_email;

    // 0 : customer inquiry
    // 1 : purchase of goods
    // 2 : password reset
    [SerializeField] GameObject emailButtons;
    [SerializeField] GameObject[] emailBodies;
    [SerializeField] GameObject backButton;

    public void Email0()
    {
        emailButtons.SetActive(false);
        emailBodies[0].SetActive(true);
        backButton.SetActive(true);
    }

    public void Email1()
    {
        emailButtons.SetActive(false);
        emailBodies[1].SetActive(true);
        backButton.SetActive(true);
    }
    public void Email2()
    {
        emailButtons.SetActive(false);
        emailBodies[2].SetActive(true);
        backButton.SetActive(true);
    }

    public void OnClick_ResetEmail()
    {
        emailButtons.SetActive(true);

        foreach (GameObject email in emailBodies)
        {
            email.SetActive(false);
        }

        backButton.SetActive(false);
    }
}
