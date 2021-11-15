using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerController : MonoBehaviour
{
    private Text timerText;
    private float timer;
    private GameManager gm;

    // TOTO: Move Logic to GameManager - Event
    void Start()
    {
        gm = GameManager.Instance;
        timerText = GetComponent<Text>();
        timerText.text = TimeToString(gm.TimeCounter);
        gm.gameStateChanged.AddListener(SetTime);
    }

     string TimeToString(float time)
    {
        float min = ((int)time / 60);
        float sec = (int) (time % 60);
        return string.Format("{0:00}:{1:00}", min, sec);
    }

    void SetTime(){
        timerText.text = TimeToString(gm.TimeCounter);
    }
}
