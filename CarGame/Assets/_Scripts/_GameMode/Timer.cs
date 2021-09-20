using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 11;
    private bool timerEnabled = true;

    public Text timeText;

    public GameObject gameOverScreen;
    
    private void Update()
    {
        if (timerEnabled)
        {
            if (timeLeft > 0)
            {
                gameOverScreen.active = false;
                timeLeft -= Time.deltaTime;

            }
            else
            {
                Debug.Log("Timer Done...");
                timeLeft = 0;
                timerEnabled = false;

            }

        } else
        {
            gameOverScreen.active = true;


        }



        DisplayTime(timeLeft);
        



    }

    void DisplayTime(float timeToDisplay)
    {

         
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
