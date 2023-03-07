using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class HintSystem : MonoBehaviourPun
{
    private PhotonView photonView;

    [SerializeField] Transform container;
    [SerializeField] GameObject hint;
    List<GameObject> hintList = new List<GameObject>();

    [SerializeField] Button hintButton;
    [SerializeField] TextMeshProUGUI nextHintText;
    [SerializeField] TextMeshProUGUI viewHintText;
    int viewHintNumTest = 0;
    //GameObject[] hintList;

    int numHints = 5;
    float nextHintTimer;
    float resetNextHintTimer = 5 * 60;
    bool disableHint = false;

    private void InstantiateHint()
    {
        for (int i = 0; i < numHints; i++)
        {
            GameObject newHint = Instantiate(hint);
            newHint.transform.SetParent(container, false);
            newHint.transform.position = Vector3.zero;
            newHint.transform.localPosition = Vector3.one;
            hintList.Add(newHint);
        }
    }

    void RemoveHint()
    {
        int lastHintNum = hintList.Count - 1;
        if (lastHintNum >= 0)
        {
            Destroy(hintList[lastHintNum].gameObject);
            hintList.RemoveAt(lastHintNum);
        }
        disableHint = true;
        hintButton.interactable = false;
        nextHintText.color = Color.red;
        nextHintTimer = resetNextHintTimer;

        viewHintNumTest++;
        viewHintText.text = "Hint: " + viewHintNumTest;
    }

    public void OnClick_AskForHint()
    {
        photonView.RPC("ReceiveHint", RpcTarget.All);
    }

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        nextHintTimer = resetNextHintTimer;
        nextHintText.text = "Next Hint: Available";
        viewHintText.text = "No Hints at the moment :(";
        nextHintText.color = Color.green;
        InstantiateHint();
    }

    // Update is called once per frame
    void Update()
    {
        if (disableHint)
        {
            nextHintTimer -= Time.deltaTime; 
            int minutes = Mathf.FloorToInt(nextHintTimer / 60);
            int seconds = Mathf.FloorToInt(nextHintTimer % 60);
            nextHintText.text = "";
            nextHintText.text = "Next Hint: " + minutes + "m " + seconds + "s";
            if (nextHintTimer <= 0)
            {
                disableHint = false; 
                nextHintText.text = "Next Hint: Available";
                nextHintText.color = Color.green;
                hintButton.interactable = true;
            }
        }
    }

    [PunRPC]
    public void ReceiveHint()
    {
        RemoveHint();
    }
}
