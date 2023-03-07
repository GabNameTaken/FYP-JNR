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
    [SerializeField] GameObject[] emailbodies;
    [SerializeField] GameObject susLink;

    [SerializeField] GameObject[] emailButtons;

    //public void SusEmail()
    //{
    //    foreach (GameObject email in emailButtons)
    //    {
    //        email.SetActive(false);
    //    }
    //    img_email.sprite = emailSprites[1];
    //    susLink.SetActive(true);
    //}

    public void Email0()
    {
        foreach (GameObject email in emailButtons)
        {
            email.SetActive(false);
        }
        emailbodies[0].SetActive(true);
    }

    public void Email1()
    {
        foreach (GameObject email in emailButtons)
        {
            email.SetActive(false);
        }
        emailbodies[1].SetActive(true);
    }
    public void Email2()
    {
        foreach (GameObject email in emailButtons)
        {
            email.SetActive(false);
        }
        emailbodies[2].SetActive(true);
    }

    public void OnClick_ResetEmail()
    {
        foreach (GameObject email in emailButtons)
        {
            email.SetActive(true);
        }
        foreach (GameObject email in emailbodies)
        {
            email.SetActive(false);
        }
        //susLink.SetActive(false);
    }
}
