using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailCondition : MonoBehaviour
{
    public float failConditionHeight;
    private GameManager gm;

    void Start()
    {
     gm = GameManager.Instance;
    }

    public void Reset(){
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        // Debug.Log(transform.position.y);
        if(transform.position.y < failConditionHeight && gm.GameState == GameStateEnum.LevelRunning)
        {            
            Debug.Log("FailCondition - Update - Fail detected" + transform.position.y);            
            gm.LevelLost();
            Destroy(this);
        }
    }
}