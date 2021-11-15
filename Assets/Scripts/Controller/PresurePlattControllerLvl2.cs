using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresurePlattControllerLvl2 : MonoBehaviour
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
            SpawnerController.stopSpawn = true;
            Debug.Log("stopspawn " + SpawnerController.stopSpawn);
            animationController.StartAnimationPresurePlateDownLvl2();
            // Debug.Log("PresurePlate entered");
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("Ball"))
        {
            animationController.StartAnimationPresurePlateUpLvl2();
            // Debug.Log("PresurePlate exited");
        }
    }
}
