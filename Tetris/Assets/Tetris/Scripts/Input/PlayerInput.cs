//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Tetris/Scripts/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""On Game Board"",
            ""id"": ""539200da-1132-49c2-9992-5ad136bc56a0"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""3580530b-75c4-40cc-9be3-056c1dc6328d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""291c5cf2-5d67-4215-ba25-056cb4b3a3e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fall speed up"",
                    ""type"": ""Button"",
                    ""id"": ""93b49ea5-ba7e-4c32-89af-def65318aad1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""765080e2-9334-4426-9d63-5f10cff1c40f"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f89316ab-2354-458b-bc18-0a6368bd48a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd9d36e9-f242-4551-83d8-0cdccd60a4b0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dedcbaa-1ec2-4b70-af89-e4f21b7681ce"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""670e72c2-a190-4625-ae9b-012a9c9f72e1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3a2fa096-7b09-4ae6-a6ea-b615cd3fe2b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c6d8c08-9a77-486c-a058-f833d65adc24"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""1ab249d2-7839-481e-9ca7-322328339689"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d049193c-3d93-48b0-80ca-535ccbe4fcb1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f62bef7-3233-4c0a-a90c-f76602de2ce7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""74d0bfdf-d65b-44e0-9e90-ffcd5812ab9c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Fall speed up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb82a426-25dd-4504-8ef1-1394c2bf5f81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Fall speed up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // On Game Board
        m_OnGameBoard = asset.FindActionMap("On Game Board", throwIfNotFound: true);
        m_OnGameBoard_Moving = m_OnGameBoard.FindAction("Moving", throwIfNotFound: true);
        m_OnGameBoard_Rotation = m_OnGameBoard.FindAction("Rotation", throwIfNotFound: true);
        m_OnGameBoard_Fallspeedup = m_OnGameBoard.FindAction("Fall speed up", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // On Game Board
    private readonly InputActionMap m_OnGameBoard;
    private IOnGameBoardActions m_OnGameBoardActionsCallbackInterface;
    private readonly InputAction m_OnGameBoard_Moving;
    private readonly InputAction m_OnGameBoard_Rotation;
    private readonly InputAction m_OnGameBoard_Fallspeedup;
    public struct OnGameBoardActions
    {
        private @PlayerInput m_Wrapper;
        public OnGameBoardActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_OnGameBoard_Moving;
        public InputAction @Rotation => m_Wrapper.m_OnGameBoard_Rotation;
        public InputAction @Fallspeedup => m_Wrapper.m_OnGameBoard_Fallspeedup;
        public InputActionMap Get() { return m_Wrapper.m_OnGameBoard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnGameBoardActions set) { return set.Get(); }
        public void SetCallbacks(IOnGameBoardActions instance)
        {
            if (m_Wrapper.m_OnGameBoardActionsCallbackInterface != null)
            {
                @Moving.started -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnMoving;
                @Moving.performed -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnMoving;
                @Moving.canceled -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnMoving;
                @Rotation.started -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnRotation;
                @Fallspeedup.started -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnFallspeedup;
                @Fallspeedup.performed -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnFallspeedup;
                @Fallspeedup.canceled -= m_Wrapper.m_OnGameBoardActionsCallbackInterface.OnFallspeedup;
            }
            m_Wrapper.m_OnGameBoardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moving.started += instance.OnMoving;
                @Moving.performed += instance.OnMoving;
                @Moving.canceled += instance.OnMoving;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Fallspeedup.started += instance.OnFallspeedup;
                @Fallspeedup.performed += instance.OnFallspeedup;
                @Fallspeedup.canceled += instance.OnFallspeedup;
            }
        }
    }
    public OnGameBoardActions @OnGameBoard => new OnGameBoardActions(this);
    private int m_DefaultSchemeIndex = -1;
    public InputControlScheme DefaultScheme
    {
        get
        {
            if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
            return asset.controlSchemes[m_DefaultSchemeIndex];
        }
    }
    public interface IOnGameBoardActions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnFallspeedup(InputAction.CallbackContext context);
    }
}