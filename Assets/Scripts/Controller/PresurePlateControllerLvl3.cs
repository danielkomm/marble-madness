using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresurePlateControllerLvl3 : MonoBehaviour
{
    TorAnimationController torAnimationController;
    void Start()
    {
        torAnimationController = GetComponent<TorAnimationController>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Ball"))
        {
            torAnimationController.StartAnimationPresurePlateDownLvl3();
            // Debug.Log("PresurePlate entered");
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("Ball"))
        {
            torAnimationController.StartAnimationPresurePlateUpLvl3();
            // Debug.Log("PresurePlate exited");
        }
    }
}
