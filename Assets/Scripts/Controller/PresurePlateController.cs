using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresurePlateController : MonoBehaviour
{
    AnimationController animationController;
    void Start()
    {
        animationController = GetComponent<AnimationController>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Ball"))
        {
            animationController.StartAnimationPresurePlateDown();
            // Debug.Log("PresurePlate entered");
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("Ball"))
        {
            animationController.StartAnimationPresurePlateUp();
            // Debug.Log("PresurePlate exited");
        }
    }
}