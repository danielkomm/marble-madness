using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonCameraController : MonoBehaviour
{
public Camera cameracontrolls;
    public GameObject player;
    public float minZoom = 0.0f;
    public float maxZoom = 20;
    public float scrollSpeed = 1f;
    public float offsetHeight = 1;

    private float _offsetDistance;
    private float maxOffsetDistance;
    private Vector3 _offsetDirection;
    private Vector3 offset;
    private RaycastHit hit;

    private Vector2 _mouseInput;

    private float _zoomInput;

    void Start()                                                                                                                                    //Definition des Kamera-Abstands (offsets)
    {
        // Cursor.lockState = CursorLockMode.Locked;

        _offsetDirection = transform.position - player.transform.position;                                                                           //Holen und setzen der ersten Offset-Werte
        maxOffsetDistance = _offsetDirection.magnitude;
        _offsetDistance = maxOffsetDistance;
        _offsetDirection = _offsetDirection.normalized;
    }

    void OnMouseLock(InputValue value){
        _mouseInput = value.Get<Vector2>(); // Steuerinput
    }

    void OnZoom(InputValue value){
        _zoomInput = value.Get<float>();
        Debug.Log("Called Zoom");
    }

    void LateUpdate()                                                                                                                               //Aktualisieren des Kamera-Abstands nach jedem Frame
    {
        CameraRotation(_mouseInput);
        CameraDistance(_zoomInput);
        setCameraPos(_offsetDirection, _offsetDistance);
    }

    private void setCameraPos(Vector3 offsetDirection, float offsetDistance){
        offset = offsetDirection * offsetDistance;
        transform.position = player.transform.position + offset;                                                                                    //Setzen der Kameraposition (Ballposition + offset)

        transform.LookAt(player.transform.position, Vector3.up);
        transform.position += new Vector3(0, offsetHeight, 0);
    }

    private void CameraDistance(float zoomInput){
        _offsetDistance -= zoomInput * scrollSpeed * Time.deltaTime;
        _offsetDistance = Mathf.Clamp(_offsetDistance, minZoom, maxZoom);  

        int layermask = ~(1 << 8);                                                                                                                  //Definieren einer Layermaske zum prüfen der Abstände zwischen Objekt & Kamera
        if (Physics.Raycast(player.transform.position + new Vector3(0, offsetHeight, 0), _offsetDirection, out hit, maxOffsetDistance, layermask))   //Bedingung zum prüfen, ob die Kamera mit einem Objekt kollidieren würde
        {
                _offsetDistance = hit.distance;  
                                                                                                           //Anpassen des Kameraabstands
        }                                                                       //mathematische Berechnung der möglichen Abstände
    }
    private void CameraRotation(Vector2 mouseInput){                                                                                                                                //Holen der X und Y-Inputwerte der Maus
        _offsetDirection = (Quaternion.AngleAxis(mouseInput.x, new Vector3(0, 1, 0)) * _offsetDirection).normalized;                                      //Setzen der X-OffsetDirection
        _offsetDirection = (Quaternion.AngleAxis(-mouseInput.y, transform.right) * _offsetDirection).normalized;                                          //Setzen der Y-OffsetDirection
    }
}
