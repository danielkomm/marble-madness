using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorAnimationController : MonoBehaviour
{
    [SerializeField] private Animator Presureplate;
    [SerializeField] private Animator TorLinks;
    [SerializeField] private Animator TorRechts;


    public void StartAnimationPresurePlateUpLvl3()
    {
        Presureplate.SetBool("play3", false);
    }

    public void StartAnimationPresurePlateDownLvl3()
    {
        Presureplate.SetBool("play3", true);
        StartAnimationOpenDoor();
    }

    public void StartAnimationOpenDoor()
    {
        TorLinks.SetBool("openL", true);
        TorRechts.SetBool("openR", true);
    }
}
