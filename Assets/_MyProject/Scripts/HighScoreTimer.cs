using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreTimer : MonoBehaviour
{

    private float currentTime;
    private bool timerActive;
    [SerializeField] private TMP_Text timerText;


    void Start()
    {
        // Start time at 0
        currentTime = 0f;
        timerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        // If timer is active, display the added time starting at 0 (current time)
        if (timerActive)
        {
            currentTime += Time.deltaTime;
        }
        // Using TimeSpan you can separate hours, minutes, seconds, now store it within the time variable
        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        // Display minutes and seconds on screen rounding to 2 numbers
        timerText.text = "Timer: " + time.Minutes.ToString("00") + ":" + time.Seconds.ToString("00");

    }
}
