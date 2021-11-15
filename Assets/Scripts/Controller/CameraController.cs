using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{

    public float zoomSensitivity = 0.5f;
    private GameObject ball;
    private float _zoomValue;
    private float _zoom;

    void Start(){
        ball = GameObject.Find("Ball");
    }


    void LateUpdate()
    {
        _zoom += _zoomValue * zoomSensitivity;
        MoveCamera(_zoom);
    }

    void OnZoom(InputValue value){
        _zoomValue = value.Get<float>();
    }

    private void MoveCamera(float zoomValue){
        Vector3 ballPos = ball.transform.position;
        transform.position = new Vector3(ballPos.x, ballPos.y + 5 - (zoomValue *  1/4), ballPos.z - 10 + (zoomValue * 1/2));
    }
}