using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    GameManager gm;
    void Start()
    {
        gm = GameManager.Instance;
    }

    void OnCollisionEnter(Collision theCollision)
    {
        gm.LevelLost();
    }
}
