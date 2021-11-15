using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private GameManager gm;
    void Start(){
        gm = GameManager.Instance;
    }

// Main Menue Buttons
    public void StartButton(){
       gm.StartLevel();
    }
    public void QuitButton(){
       Application.Quit();
    }

// End Menu Button
    public void MenuButton(){
       gm.StartMainMenu();
    }

    public void SaveStatsButton(){
       gm.SaveCurrentStats();
    }

// HUD Buttons
    public void NextLevelHUD(){
       gm.NextLevel();
    }
    public void ContinueLevelHUD(){
       gm.ContinueLevel();
    }
    public void PauseLevelHUD(){
       gm.PauseLevel();
    }
}
