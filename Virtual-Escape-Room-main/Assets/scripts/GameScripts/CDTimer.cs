using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class CDTimer : MonoBehaviourPun
{
    public bool timerIsRunning;
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] LevelLoader levelloader;
    [SerializeField] TextMeshProUGUI cdTimerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        timerIsRunning = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            
        }
        else
        {
            Debug.Log("Time has run out!");
            currentTime = 0;
            timerIsRunning = false;
        }

        DisplayTime(currentTime);


        
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        cdTimerText.text = "";
        if (timerIsRunning == true && (currentTime > 0))
        {
            cdTimerText.text = "TIMER :" + string.Format("{0:00}:{1:00}", minutes, seconds);
        }
       

        else if (timerIsRunning == false && (currentTime == 0))
        {
            cdTimerText.text = "GAME OVER";
            levelloader.LoadNextLevel("GameOverScene");
        }
    }

}
