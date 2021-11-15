using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject spawner;
    public static bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay;
    GameManager gm;

    void Start()
    {
        gm = GameManager.Instance;
        if (!stopSpawn)
        {
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        }
    }

    public void SpawnObject()
    {

        if (!stopSpawn)
        {
            Instantiate(spawner, transform.position, transform.rotation);
        }
        else
        {
            CancelInvoke("SpawnObject");
        }
    }
}
