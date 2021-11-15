using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentSphereController : MonoBehaviour
{
    GameManager gm;
    public float destroyHeight;
    private Vector3 _startPos;
    private Vector3 _newPosition;

    void Start()
    {
        gm = GameManager.Instance;
    }
    void Update()
    {
        _newPosition = transform.position;
        _newPosition.x -= Mathf.Sin(Time.time) * Time.deltaTime;
        transform.position = _newPosition;
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.CompareTag("Ball"))
        {
            gm.LevelLost();
        }
    }
}