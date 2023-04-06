using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    [SerializeField] GameObject[] tips;
    [SerializeField] GameObject tip;

    private int currentTip = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetTipActive(int i)
    {
        currentTip = i;
        tip.SetActive(true);
        tips[currentTip].SetActive(true);
    }

    public void CloseTip()
    {
        tips[currentTip].SetActive(false);
        tip.SetActive(false);
    }

}
