using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    public float gameDuration = 60f; // Set the duration of the game in seconds
    private float timer;

    void Start()
    {
        timer = gameDuration;
        UpdateTimerUI();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            // Implement what should happen when the timer reaches zero (e.g., end the game).
            Debug.Log("Game Over!");
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            // Display time as minutes and seconds
            int minutes = Mathf.FloorToInt(timer / 60f);
            int seconds = Mathf.FloorToInt(timer % 60f);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
