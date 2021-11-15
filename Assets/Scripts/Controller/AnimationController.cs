using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator MovingObject;
    [SerializeField] private Animator Presureplate;

    public void StartAnimationPresurePlateDown()
    {
        Presureplate.SetBool("play", true);
        StartAnimationMovePlateWithCoin();
    }

    public void StartAnimationPresurePlateUp()
    {
        Presureplate.SetBool("play", false);
    }

    public void StartAnimationPresurePlateDownLvl2()
    {
        Presureplate.SetBool("play2", true);
        StartAnimationOfExecutionDoor();
    }


    public void StartAnimationPresurePlateUpLvl2()
    {
        Presureplate.SetBool("play2", false);
    }

    public void StartAnimationMovePlateWithCoin()
    {
        MovingObject.SetBool("playother", true);
    }

    public void StartAnimationOfExecutionDoor(){
        MovingObject.SetBool("exec", true);
    }

    public void StartAnimationOpenDoor(){
        MovingObject.SetBool("open", true);
    }
}
