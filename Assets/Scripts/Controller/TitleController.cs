using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{

    private GameManager gm;
    Text title;
    void Start()
    {
        Debug.Log("TitleController - Start - Sets Title");
        gm = GameManager.Instance;
        title = gameObject.GetComponent<Text>(); 
        gm.gameStateChanged.AddListener(SetTitle);
        SetTitle();
    }

    private void SetTitle(){
        switch(gm.GameState){
            case(GameStateEnum.GameWon):
                title.text = "Congratulation! You Won!";
                break;
            case(GameStateEnum.GameLost):
                title.text = "You Lost!";
                break;
        }
    }
}
