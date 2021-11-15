// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""c56aac14-76de-443d-8d43-3ce485dfba96"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d320f23e-6639-40f0-b11c-4ea83c876744"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""4239272e-d7e3-4b02-bf03-4d403e8099ad"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""e73dfa59-3154-440e-909c-39fa8c6ea196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseLock"",
                    ""type"": ""Value"",
                    ""id"": ""87687477-8cbb-4461-b9fe-8eb1583ccb92"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchCamera"",
                    ""type"": ""Button"",
                    ""id"": ""01882121-58f0-4c19-bf66-3cf2a36fc3df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aebb3269-13f7-4d64-bd47-ad943849a838"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3fdde196-daf3-4ff7-8695-0a1f60176304"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56ef0179-3fee-48a8-ab6b-c6cef05e326a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d8c2529-ea49-4c60-badc-f9cea2c2bdb8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d0426ff4-0213-4e16-9466-e46fce4f390d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""019aa837-2183-49e6-acc7-db32f69b9e6d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cf519e6b-bb07-4ad6-9c85-350b001b9cb2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""287da8a7-df24-4bee-8848-7931169ae742"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c36cbd8a-1ee5-4dbc-8e2f-dcf01a6871fe"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c543d38-aa09-43d3-9c6d-30bc51dac307"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""518917e4-d31e-450b-b7fb-57ffb021bf53"",
                    ""path"": ""<VirtualMouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""320f5f13-ea66-4411-874c-2a5a62b18ef9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6a588415-ed73-4c73-9d2d-69b1c2a095b3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""67d31b67-b818-40e5-8353-b532e3f1beb7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CannonSteering"",
            ""id"": ""0e0132e4-d4e3-4e66-b063-4161111d0596"",
            ""actions"": [
                {
                    ""name"": ""Align"",
                    ""type"": ""Value"",
                    ""id"": ""69c7babd-f054-4d9b-ae55-b8bcf9759bff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5446a5b-a12d-49ad-8614-08d4fb6db8d5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Align"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9922aecd-a2b4-4875-81cb-30d939f10193"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Align"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9044f202-a07d-48bc-a197-f6f9312cb4a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Align"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bdd0eda4-ecba-4c0a-bef2-961e5a1765b8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Align"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""348973e2-18e3-4347-81d0-76b45d98b11e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Align"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7793cf0c-211f-4e94-b5d5-ba6083ee9924"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Align"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Moving
        m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
        m_Moving_Move = m_Moving.FindAction("Move", throwIfNotFound: true);
        m_Moving_Jump = m_Moving.FindAction("Jump", throwIfNotFound: true);
        m_Moving_Pause = m_Moving.FindAction("Pause", throwIfNotFound: true);
        m_Moving_MouseLock = m_Moving.FindAction("MouseLock", throwIfNotFound: true);
        m_Moving_SwitchCamera = m_Moving.FindAction("SwitchCamera", throwIfNotFound: true);
        m_Moving_Zoom = m_Moving.FindAction("Zoom", throwIfNotFound: true);
        // CannonSteering
        m_CannonSteering = asset.FindActionMap("CannonSteering", throwIfNotFound: true);
        m_CannonSteering_Align = m_CannonSteering.FindAction("Align", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Moving
    private readonly InputActionMap m_Moving;
    private IMovingActions m_MovingActionsCallbackInterface;
    private readonly InputAction m_Moving_Move;
    private readonly InputAction m_Moving_Jump;
    private readonly InputAction m_Moving_Pause;
    private readonly InputAction m_Moving_MouseLock;
    private readonly InputAction m_Moving_SwitchCamera;
    private readonly InputAction m_Moving_Zoom;
    public struct MovingActions
    {
        private @Controls m_Wrapper;
        public MovingActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Moving_Move;
        public InputAction @Jump => m_Wrapper.m_Moving_Jump;
        public InputAction @Pause => m_Wrapper.m_Moving_Pause;
        public InputAction @MouseLock => m_Wrapper.m_Moving_MouseLock;
        public InputAction @SwitchCamera => m_Wrapper.m_Moving_SwitchCamera;
        public InputAction @Zoom => m_Wrapper.m_Moving_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void SetCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                @MouseLock.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMouseLock;
                @MouseLock.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMouseLock;
                @MouseLock.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMouseLock;
                @SwitchCamera.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnSwitchCamera;
                @SwitchCamera.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnSwitchCamera;
                @SwitchCamera.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnSwitchCamera;
                @Zoom.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @MouseLock.started += instance.OnMouseLock;
                @MouseLock.performed += instance.OnMouseLock;
                @MouseLock.canceled += instance.OnMouseLock;
                @SwitchCamera.started += instance.OnSwitchCamera;
                @SwitchCamera.performed += instance.OnSwitchCamera;
                @SwitchCamera.canceled += instance.OnSwitchCamera;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MovingActions @Moving => new MovingActions(this);

    // CannonSteering
    private readonly InputActionMap m_CannonSteering;
    private ICannonSteeringActions m_CannonSteeringActionsCallbackInterface;
    private readonly InputAction m_CannonSteering_Align;
    public struct CannonSteeringActions
    {
        private @Controls m_Wrapper;
        public CannonSteeringActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Align => m_Wrapper.m_CannonSteering_Align;
        public InputActionMap Get() { return m_Wrapper.m_CannonSteering; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CannonSteeringActions set) { return set.Get(); }
        public void SetCallbacks(ICannonSteeringActions instance)
        {
            if (m_Wrapper.m_CannonSteeringActionsCallbackInterface != null)
            {
                @Align.started -= m_Wrapper.m_CannonSteeringActionsCallbackInterface.OnAlign;
                @Align.performed -= m_Wrapper.m_CannonSteeringActionsCallbackInterface.OnAlign;
                @Align.canceled -= m_Wrapper.m_CannonSteeringActionsCallbackInterface.OnAlign;
            }
            m_Wrapper.m_CannonSteeringActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Align.started += instance.OnAlign;
                @Align.performed += instance.OnAlign;
                @Align.canceled += instance.OnAlign;
            }
        }
    }
    public CannonSteeringActions @CannonSteering => new CannonSteeringActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IMovingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMouseLock(InputAction.CallbackContext context);
        void OnSwitchCamera(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface ICannonSteeringActions
    {
        void OnAlign(InputAction.CallbackContext context);
    }
}
