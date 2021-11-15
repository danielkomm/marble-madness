using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Ball")){
            GameManager.Instance.LevelLost();
        }
    }
}
