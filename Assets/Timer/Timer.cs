using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Reference to the TextMeshProUGUI component to display the timer
    public float countdownTime = 60f; // Countdown time in seconds

    private float timeRemaining; // Time remaining in the countdown
    private bool timerActive = true; // Flag to indicate if the timer is active

    void Start()
    {
        timeRemaining = countdownTime;
    }

    void Update()
    {
        // Check if the timer is active
        if (timerActive)
        {
            // Update the countdown timer
            timeRemaining -= Time.deltaTime;

            // Update the timer display
            UpdateTimerDisplay();

            // Check if the countdown timer has reached zero
            if (timeRemaining <= 0f)
            {
                // Timer has reached zero, do something (e.g., end game)
                timerActive = false;
                timeRemaining = 0f;
                Debug.Log("Timer reached zero!");
            }
        }
    }

    void UpdateTimerDisplay()
    {
        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}