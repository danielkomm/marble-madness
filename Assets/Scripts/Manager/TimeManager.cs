using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    private Text timerText;
    private float startTime;
    private float timeDiff;
    bool trackTime;
    float timer;
    private GameManager gm;

    void Start()
    {
        gm = GameManager.Instance;
        timerText = GetComponent<Text>();
        timerText.text = TimeToString(timer);
        timeDiff = timer;
        gm.gameStateChanged.AddListener(SetTime);
        SetTime();
    }

    void SetTime()
    {
        Debug.Log("TimerController - setTime - " + gm.GameState);
        switch (gm.GameState)
        {
            case (GameStateEnum.LevelAccomplished):
                gm.TimeCounter = timer;
                StopTimer();
                break;
            case (GameStateEnum.LevelLost):
                gm.TimeCounter = timer;
                StopTimer();
                break;
            case (GameStateEnum.GameLost):
                gm.TimeCounter = timer;
                StopTimer();
                break;
            case (GameStateEnum.GameWon):
                gm.TimeCounter = timer;                
                StopTimer();
                break;
            case (GameStateEnum.LevelPaused):
                gm.TimeCounter = timer;
                StopTimer();
                break;
            case (GameStateEnum.LevelRunning):
                if (gm.TimeCounter >= 0.01)
                {
                    timer = gm.TimeCounter;
                    ResumeTimer();
                }
                else
                {
                    StartTimer();
                }
                break;
        }
    }

    void Update()
    {
        if (trackTime)
        {
            UpdateTime();
        }
    }

    void UpdateTime()
    {

        timer = Time.time - startTime;

        if ((timer - timeDiff) >= 01.00)
        {
            timeDiff = timer;
            timerText.text = TimeToString(timer);
        }
    }

    void StartTimer()
    {
        trackTime = true;
        startTime = Time.time;
    }

    void ResumeTimer()
    {
        trackTime = true;
        startTime = Time.time - timer;
    }

    float StopTimer()
    {
        trackTime = false;
        return timer;
    }

    string TimeToString(float time)
    {
        float min = ((int)time / 60);
        float sec = (int)(time % 60);
        return string.Format("{0:00}:{1:00}", min, sec);
    }
}
