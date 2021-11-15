using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    // Cannon Rotatition
    public float lerpSpeed = 5f;
    public GameObject target;
    public GameObject ammunition;
    public float firePower = 100f;
    public float range = 20f;
    public float fireRate = 3.0f;
    public float pitch = 3f; //pitchFactor: lifts the Bullet. depending on the distance (automated)

    private Quaternion fromRotation;
    private Quaternion toRotation;
    private GameObject upperTower;
    private GameObject bulletLauncher;
    private float deltaTime;
    private Rigidbody bulletRb;


    void Start(){
        if(target == null){
            target = GameObject.Find("Ball");
        }

        upperTower = transform.Find("TowerWeappon").gameObject;
        bulletLauncher = transform.Find("TowerWeappon").Find("Barrel").Find("BulletLauncher").gameObject;
    }

    void Update(){
        if(Vector3.Distance(target.transform.position, transform.position) <= range){
            Vector3 targetPos = target.transform.position - upperTower.transform.position;
            targetPos.y += pitch * Vector3.Distance(target.transform.position, transform.position) * 0.01f;
            fromRotation = upperTower.transform.rotation;
            toRotation = Quaternion.LookRotation(targetPos, Vector3.up);
            upperTower.transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * lerpSpeed);

            deltaTime += Time.deltaTime;
            if(deltaTime >= fireRate){

                FireShot();
                deltaTime = 0f;
            }  
        }    
    }

    private void FireShot(){
        GameObject bullet = Instantiate(ammunition, bulletLauncher.transform.position, bulletLauncher.transform.rotation) as GameObject;
        bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(bulletLauncher.transform.forward * firePower);
    }

}

