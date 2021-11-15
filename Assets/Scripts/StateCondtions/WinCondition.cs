using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(MeshCollider))]
public class WinCondition : MonoBehaviour
{
GameManager gm;
MeshCollider detectFin;
    void Start()
    {
        gm = GameManager.Instance;

        MeshCollider detectFin = GetComponent<MeshCollider>();
        detectFin.enabled = true;
        detectFin.convex = true;
        detectFin.isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        gm.LevelWon();
    }

}