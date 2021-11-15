using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class InputControlPlayer : MonoBehaviour
{
    // [SerializeField] private InputActionReference _movement;
    public float movingSpeed = 100;
    public float jumpingForce = 5;
    public int allowedJumpInARow = 1;

    private Vector3 _direction;
    private float _jump;
    private float _jumpCount;
    private bool _isGrounded;

    private Rigidbody _rb;
    private PlayerInput _playerInput;

    private ControlManager controlManager = ControlManager.Instance;
    private Transform _activeCamPos;

    void Start()
    {
        OponentManager.Instance.playerStatsChanged.AddListener(ChangeSpeed);
        controlManager.activeControlChanged.AddListener(CheckActiveControl);
        _isGrounded = true;
        _rb = GetComponent<Rigidbody>();
        _playerInput = GetComponent<PlayerInput>();
        _activeCamPos = GetComponent<SwitchCameraController>().GetCurrentCamera().transform;
    }

    void Update()
    {
        Move(_direction);
        if (_isGrounded)
        {
            Jump(_jump);
        }

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boden"))
        {
            _isGrounded = true;
            _jumpCount = 0;
        }
    }

    void OnCollisionExit(Collision theCollision)
    {
        //empty - never used
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>(); // Steuerinput
        _direction = new Vector3(input.x, 0.0f, input.y);
        Debug.Log("ForwardTransform" + _activeCamPos.forward.z);
        _direction = (_activeCamPos.forward * _direction.z) + (_activeCamPos.right * _direction.x);
        _direction.y = 0f;
    }

    void OnJump(InputValue value)
    {
        _jump = value.Get<float>(); // can only be 1 or 0;
        _jumpCount++;
        _isGrounded = _jumpCount <= allowedJumpInARow;
    }

    void OnPause()
    {
        switch (GameManager.Instance.GameState)
        {
            case (GameStateEnum.LevelPaused):
                GameManager.Instance.ContinueLevel();
                break;

            case (GameStateEnum.LevelRunning):
                GameManager.Instance.PauseLevel();
                break;
        }
    }

    void OnSwitchCamera(InputValue value){
        _activeCamPos = GetComponent<SwitchCameraController>().GetCurrentCamera().transform;
    }

    void Move(Vector3 direct)
    {
        _rb.AddForce(direct * Time.deltaTime * movingSpeed);
    }

    void Jump(float jump)
    {
        _rb.AddForce(Vector3.up * jumpingForce * jump, ForceMode.Impulse);
        _isGrounded = false;
    }


    private void ChangeSpeed()
    {
        _rb.drag = OponentManager.Instance.dragValue;
    }

    private void CheckActiveControl()
    {
        if (controlManager.ActiveControl == ActiveControlEnum.Player)
        {
            _playerInput.actions.FindActionMap("Moving").Enable();
            Debug.Log("InputControllPlayer Player Movoing");
        }
        else
        {
            _playerInput.actions.FindActionMap("Moving").Disable();
            Debug.Log("InputControllPlayer Player stoped Movoing");
        }
    }
}
