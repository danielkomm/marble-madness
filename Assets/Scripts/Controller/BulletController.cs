using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float timeToLifeAfterMiss = 5f;
    public GameObject target;
    
    private bool missed, shotFired;
    private float destroyTimer;
    private float killTimer;
    private float damageDelay = 0.1f;
    private Rigidbody rb;

    void Start()
    {
        if(target == null){
            target = GameObject.Find("Ball");
        }
        missed = false;
        shotFired = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(missed){
            destroyTimer += Time.deltaTime;
        }
        if(destroyTimer >= timeToLifeAfterMiss){
            Destroy(gameObject);
        }
        if(shotFired){
            killTimer += Time.deltaTime;
            CheckDamageTime();
        }
        
    }

    void OnCollisionEnter(Collision coll){
         if (coll.gameObject.CompareTag("Ball") && !missed){
             GameManager.Instance.LevelLost();
         } else {
             shotFired = true;
         }
    }

    public void CheckDamageTime(){
        Debug.Log("Called:" + rb.velocity.magnitude);
        if(killTimer > Vector3.Distance(target.transform.position, transform.position) / rb.velocity.magnitude + damageDelay){
            Debug.Log("Cannon Missed");
            missed = true;
        }
    }
}
