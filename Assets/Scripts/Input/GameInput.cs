// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""6cec6b23-7e8c-439e-a2d5-9443a77e6901"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cb3e0cef-cb64-4e34-9455-909c85297f36"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""a068c1bd-0c27-4afe-adb7-b1ff2ad65925"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackPrimary"",
                    ""type"": ""Button"",
                    ""id"": ""ed5f0407-471a-4c70-b4b8-639fdc012751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackSecondary"",
                    ""type"": ""Button"",
                    ""id"": ""25de134d-be03-47df-9623-18f4dab9ae01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""039a6351-e2c2-4f74-962e-2bd1a55a1518"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""fc84824c-fb57-4e90-8fa3-6fd30d438f39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""200e31b1-00eb-48aa-944e-25fb6fd9ffde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c6ebebe-9ca2-475c-82ee-d2d1810e6595"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""56769bf0-7ca4-4344-93c0-b10d67daf101"",
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
                    ""id"": ""ed8bab86-4a29-47f9-836e-b1ba9e9e4476"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""86e62258-c75d-4269-8dd1-78cf51914d75"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""370dcb83-0c55-436e-94d9-7900d28b8ba7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0486d819-a5dc-471b-82e4-5576d0db8d16"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""50f53c29-d79a-43f4-bbf0-77448cb67ee0"",
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
                    ""id"": ""590692af-bd94-4fa3-89e0-64b6006362ba"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""39ee8e66-2037-47c2-ba79-ba16fccc80fd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8affb39b-62a6-450e-8109-1205c58c27bd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6a984093-bfb7-43ea-952e-35cd987f4cbe"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7bbbc88a-531d-47e6-a5fc-c4583b95455e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9145c3e4-0129-48d2-a139-e90ba7526c68"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f58cfa9-089c-48bc-b40e-23b98960ae24"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b8c38ac-51d7-4723-841f-35b2ec4ef070"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24f6e110-b4da-4526-9a59-f24620804ffc"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.8)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da7838c9-52c3-4979-98d0-9c9b9f5244b0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3f32b32-01a8-4ab6-a4bc-ea7df25dca63"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad93440a-1c66-4387-8dd1-d8a1eb77ee19"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""baa0263b-eb39-4a6e-a29a-eaec2069d7ee"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59764689-1e3e-4231-9b5d-38761ecea336"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc576c2b-43a9-45bd-9d02-72c43dc1ab7a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8374233-ea8b-4e95-87eb-ab3e4ef69831"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_RotateCamera = m_Gameplay.FindAction("RotateCamera", throwIfNotFound: true);
        m_Gameplay_AttackPrimary = m_Gameplay.FindAction("AttackPrimary", throwIfNotFound: true);
        m_Gameplay_AttackSecondary = m_Gameplay.FindAction("AttackSecondary", throwIfNotFound: true);
        m_Gameplay_Boost = m_Gameplay.FindAction("Boost", throwIfNotFound: true);
        m_Gameplay_Brake = m_Gameplay.FindAction("Brake", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_RotateCamera;
    private readonly InputAction m_Gameplay_AttackPrimary;
    private readonly InputAction m_Gameplay_AttackSecondary;
    private readonly InputAction m_Gameplay_Boost;
    private readonly InputAction m_Gameplay_Brake;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @RotateCamera => m_Wrapper.m_Gameplay_RotateCamera;
        public InputAction @AttackPrimary => m_Wrapper.m_Gameplay_AttackPrimary;
        public InputAction @AttackSecondary => m_Wrapper.m_Gameplay_AttackSecondary;
        public InputAction @Boost => m_Wrapper.m_Gameplay_Boost;
        public InputAction @Brake => m_Wrapper.m_Gameplay_Brake;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @RotateCamera.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCamera;
                @AttackPrimary.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackPrimary;
                @AttackPrimary.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackPrimary;
                @AttackPrimary.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackPrimary;
                @AttackSecondary.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackSecondary;
                @AttackSecondary.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackSecondary;
                @AttackSecondary.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttackSecondary;
                @Boost.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @Brake.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBrake;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @AttackPrimary.started += instance.OnAttackPrimary;
                @AttackPrimary.performed += instance.OnAttackPrimary;
                @AttackPrimary.canceled += instance.OnAttackPrimary;
                @AttackSecondary.started += instance.OnAttackSecondary;
                @AttackSecondary.performed += instance.OnAttackSecondary;
                @AttackSecondary.canceled += instance.OnAttackSecondary;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnAttackPrimary(InputAction.CallbackContext context);
        void OnAttackSecondary(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
