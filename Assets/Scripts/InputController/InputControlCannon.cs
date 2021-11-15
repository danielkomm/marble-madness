using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInput))]
public class InputControlCannon : MonoBehaviour
{
    // Components
    public float turningSpeed = 5f;
    private Rigidbody _rb;
    private PlayerInput _playerInput;

    // Private variables
    private Vector2 _input;
    private Quaternion _fromRotation;
    private Quaternion _toRotation;
    private ControlManager controlManager = ControlManager.Instance;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerInput = GetComponent<PlayerInput>();
        controlManager.activeControlChanged.AddListener(CheckActiveControl);
    }

    private void CheckActiveControl(){
        if(controlManager.ActiveControl == ActiveControlEnum.Cannon){
            _playerInput.actions.FindActionMap("Cannon Steering").Enable();
           // _playerInput.SwitchCurrentActionMap("CannonSteering");
            Debug.Log("InputControlCannon Cannon Movoing");
        } else {
            _playerInput.actions.FindActionMap("Cannon Steering").Disable();
             Debug.Log("InputControlCannon Cannon stoped Movoing");

        }
    }

    void Update()
    {
        Align(_input); // Richtet Cannon aus
    }

    void OnAlign(InputValue value){
        _input = value.Get<Vector2>();
         Debug.Log("Align is Called" + _input.x + ":" +_input.y);
    }

    void Align(Vector2 alignInput){
        _fromRotation = transform.rotation;
        _toRotation = Quaternion.Euler(alignInput.x, alignInput.y, 0.0f);
        transform.rotation = Quaternion.Lerp(_fromRotation, _toRotation, Time.deltaTime * turningSpeed);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ball")){
            controlManager.SetActiveControl(ActiveControlEnum.Cannon);
        }
    }
    
}
