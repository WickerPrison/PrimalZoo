//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ZooPlayer"",
            ""id"": ""5897869f-c8f2-4a58-8854-8af147b9a0a7"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""3a08e971-8cc5-4f89-b987-bc2fd7b28498"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchMode"",
                    ""type"": ""Button"",
                    ""id"": ""211c9e06-e96b-4021-b272-8b26b18b3ad7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ea30a48-700c-4b82-af2e-e82e52d55828"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0704d915-ca24-4b81-a284-35a9b62960d5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4d3e0a50-a351-4f81-bc5b-9dce137af629"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3fcceb02-a81d-46ab-befb-05eb32115b38"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7a6a3342-54b1-4269-b496-b6824f0b6966"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd4c0f50-1e60-4ebd-abf3-b31ab92fe0ba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ZooBuild"",
            ""id"": ""bf0c1ba6-42e5-4947-97a8-4161c52344ef"",
            ""actions"": [
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Value"",
                    ""id"": ""1b7610da-307c-419c-ae1a-6b35b4a4d4c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchMode"",
                    ""type"": ""Button"",
                    ""id"": ""4519b05a-bb3d-4fd5-a4dc-7717a49044c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""5875f73b-d5d9-4d62-9b86-c945099bf0cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9958a870-4021-421f-9dbc-6e89d86fcfb3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e45056a8-fbe4-449e-a695-5a4cd92a7ed6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c9ae54b-96da-4eb0-a839-9885c0f69fb9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d5c2c4d4-0b9f-485b-afcd-8c372e0b8e27"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87d3ab21-6de6-42bf-99e8-68890b56dfd4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df78fe61-5986-48df-a580-1e0a261fe69d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eedfae17-d387-493c-9078-6533149a60cb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ZooPlayer
        m_ZooPlayer = asset.FindActionMap("ZooPlayer", throwIfNotFound: true);
        m_ZooPlayer_Walk = m_ZooPlayer.FindAction("Walk", throwIfNotFound: true);
        m_ZooPlayer_SwitchMode = m_ZooPlayer.FindAction("SwitchMode", throwIfNotFound: true);
        // ZooBuild
        m_ZooBuild = asset.FindActionMap("ZooBuild", throwIfNotFound: true);
        m_ZooBuild_MoveCamera = m_ZooBuild.FindAction("MoveCamera", throwIfNotFound: true);
        m_ZooBuild_SwitchMode = m_ZooBuild.FindAction("SwitchMode", throwIfNotFound: true);
        m_ZooBuild_LeftClick = m_ZooBuild.FindAction("LeftClick", throwIfNotFound: true);
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

    // ZooPlayer
    private readonly InputActionMap m_ZooPlayer;
    private IZooPlayerActions m_ZooPlayerActionsCallbackInterface;
    private readonly InputAction m_ZooPlayer_Walk;
    private readonly InputAction m_ZooPlayer_SwitchMode;
    public struct ZooPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public ZooPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_ZooPlayer_Walk;
        public InputAction @SwitchMode => m_Wrapper.m_ZooPlayer_SwitchMode;
        public InputActionMap Get() { return m_Wrapper.m_ZooPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZooPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IZooPlayerActions instance)
        {
            if (m_Wrapper.m_ZooPlayerActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnWalk;
                @SwitchMode.started -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnSwitchMode;
                @SwitchMode.performed -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnSwitchMode;
                @SwitchMode.canceled -= m_Wrapper.m_ZooPlayerActionsCallbackInterface.OnSwitchMode;
            }
            m_Wrapper.m_ZooPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @SwitchMode.started += instance.OnSwitchMode;
                @SwitchMode.performed += instance.OnSwitchMode;
                @SwitchMode.canceled += instance.OnSwitchMode;
            }
        }
    }
    public ZooPlayerActions @ZooPlayer => new ZooPlayerActions(this);

    // ZooBuild
    private readonly InputActionMap m_ZooBuild;
    private IZooBuildActions m_ZooBuildActionsCallbackInterface;
    private readonly InputAction m_ZooBuild_MoveCamera;
    private readonly InputAction m_ZooBuild_SwitchMode;
    private readonly InputAction m_ZooBuild_LeftClick;
    public struct ZooBuildActions
    {
        private @PlayerControls m_Wrapper;
        public ZooBuildActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_ZooBuild_MoveCamera;
        public InputAction @SwitchMode => m_Wrapper.m_ZooBuild_SwitchMode;
        public InputAction @LeftClick => m_Wrapper.m_ZooBuild_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_ZooBuild; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZooBuildActions set) { return set.Get(); }
        public void SetCallbacks(IZooBuildActions instance)
        {
            if (m_Wrapper.m_ZooBuildActionsCallbackInterface != null)
            {
                @MoveCamera.started -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnMoveCamera;
                @SwitchMode.started -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnSwitchMode;
                @SwitchMode.performed -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnSwitchMode;
                @SwitchMode.canceled -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnSwitchMode;
                @LeftClick.started -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_ZooBuildActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_ZooBuildActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @SwitchMode.started += instance.OnSwitchMode;
                @SwitchMode.performed += instance.OnSwitchMode;
                @SwitchMode.canceled += instance.OnSwitchMode;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public ZooBuildActions @ZooBuild => new ZooBuildActions(this);
    public interface IZooPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnSwitchMode(InputAction.CallbackContext context);
    }
    public interface IZooBuildActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnSwitchMode(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
