using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThornsController : MonoBehaviour

{
    GameManager gm;
    public AudioClip thornSound;

    void Start()
    {
        gm = GameManager.Instance;

    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(thornSound, transform.position);
            Debug.Log("Hit by thorn");
            gm.LevelLost();
        }
    }
}