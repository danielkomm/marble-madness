using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    GameManager gm;
    GameStateEnum gameState;
    void Start()
    {
       gm = GameManager.Instance;
       gameState = gm.GameState;
       gm.gameStateChanged.AddListener(UpdateShownHUD);
    }

    void UpdateShownHUD()
    {
        gameState = gm.GameState;
        
         Debug.Log("HUDController: Update shown HUD UI" + gameState);

        switch(gameState){
            case(GameStateEnum.LevelAccomplished):
                transform.Find("InGameStatus").gameObject.SetActive(false);
                transform.Find("AccomplishedLevelScreen").gameObject.SetActive(true);
                break;
            case(GameStateEnum.LevelLost):
                transform.Find("InGameStatus").gameObject.SetActive(false);
                transform.Find("FailedLevelStatusScreen").gameObject.SetActive(true);
                break;
            case(GameStateEnum.LevelPaused):
                transform.Find("InGameStatus").gameObject.SetActive(false);
                transform.Find("OnPauseStatusScreen").gameObject.SetActive(true);
                break;
            case(GameStateEnum.LevelRunning):
                transform.Find("InGameStatus").gameObject.SetActive(true);
                transform.Find("AccomplishedLevelScreen").gameObject.SetActive(false);
                transform.Find("FailedLevelStatusScreen").gameObject.SetActive(false);
                transform.Find("OnPauseStatusScreen").gameObject.SetActive(false);
                break;
        }
    }
}
