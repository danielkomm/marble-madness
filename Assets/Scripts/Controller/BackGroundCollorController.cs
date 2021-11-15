using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundCollorController : MonoBehaviour
{
    GameManager gm;
    Image backgroundColor;
    void Start()
    {
        Debug.Log("BackgroundColor");
        gm = GameManager.Instance;
        gm.gameStateChanged.AddListener(SetBackgroundColor);
        backgroundColor = gameObject.GetComponent<Image>();
        SetBackgroundColor(); // TODO - Change Binding
    }

    private void SetBackgroundColor(){
        Debug.Log("BackGroundController" + gm.GameState);
        switch(gm.GameState){
            case(GameStateEnum.GameWon):
                backgroundColor.color =  new Color32(93, 225, 149, 128);
                break;
            case(GameStateEnum.GameLost):
                backgroundColor.color =  new Color32(225, 100, 100, 128);
                break;
            default:
              Debug.Log("BackGroundCollorController - setBackgroundColor - No Proper GameState was Set");
              break;
        }
    }
}
