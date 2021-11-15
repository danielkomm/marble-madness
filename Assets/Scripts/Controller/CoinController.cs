using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    GameManager gm;
    public AudioClip coinSound;
    void Start()
    {
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider coll)
    {
        //If coin collides with the Ball, destroy Coin 
        if (coll.name == "Ball")
        {
            Destroy(gameObject);
            gm.RaiseCollectable();
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Debug.Log("Coin destroyed " + "Points: " + gm.pointsCounter);
        }
    }
}
