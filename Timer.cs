using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimerRunning){
            currentTime -= Time.deltaTime;

            if(currentTime <= 0.0f){
                currentTime = 0.0f;
                isTimerRunning = false;
            }
            UpdateTimerText();
            
        }
    }
    void UpdateTimerText(){
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
