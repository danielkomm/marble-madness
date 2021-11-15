using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDoorController : MonoBehaviour
{
    GameManager gm;
    [SerializeField] Animator MetalDoor1;
    [SerializeField] Animator MetalDoor2;
    [SerializeField] Animator MetalDoor3;
    [SerializeField] Animator MetalDoor4;
    [SerializeField] Animator ExecDoor;

    void Start()
    {
        gm = GameManager.Instance;
        MetalDoor1.SetBool("door", true);
        MetalDoor2.SetBool("door", true);
        MetalDoor3.SetBool("door", true);
        MetalDoor4.SetBool("door", true);
    }

    void OnCollisionEnter(Collision theCollision)
    {
        gm.LevelLost();
    }
}
