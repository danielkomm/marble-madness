using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    GameManager gm;
    void Start()
    {
        // gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gm.gameStateChanged.AddListener(SetScene);

    }

    void SetScene()
    {
        Debug.Log("SceneManger Called");
        switch(gm.GameState){
            case(GameStateEnum.MainMenu):
                SceneManager.LoadScene(0);
                break;
            case(GameStateEnum.LevelStarting):
                SceneManager.LoadScene(0);
                break;
            case(GameStateEnum.GameWon):
                SceneManager.LoadScene(2);
                break;
            case(GameStateEnum.GameLost):
                SceneManager.LoadScene(2);
                break;
        }        
    }
}
