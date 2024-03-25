//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/New Controls.inputactions
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

public partial class @NewControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""SPECTATOR"",
            ""id"": ""eb3eec42-454d-4439-af9e-dbd5617c3c6f"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""Value"",
                    ""id"": ""7eadc8e8-4e1d-4d1c-b63c-beae8a8c6afc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MOUSE"",
                    ""type"": ""Value"",
                    ""id"": ""088acc91-09c4-4500-b6ff-776a1bbfdb26"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""INTERACT"",
                    ""type"": ""Button"",
                    ""id"": ""1aaafe34-bde6-4f80-b1f8-119ea7c08e74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MOVE_UPDOWN"",
                    ""type"": ""Value"",
                    ""id"": ""b885b81b-0805-4422-b4d6-c17fbb53d8ea"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MOVE_SPEEDSLOW"",
                    ""type"": ""Button"",
                    ""id"": ""4754e991-eef6-4b1f-9249-211161fff848"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FIRE"",
                    ""type"": ""Button"",
                    ""id"": ""7210f2c5-0222-4208-97d8-9e9412807f25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6758788c-4188-40ec-bdcd-a17345b673a0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bb2f4095-3e66-4b6e-b620-c5197a9d8109"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""efb2a92c-b7c1-4d08-b61c-18f34d11b672"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f893dfbb-fa4e-421c-b1e2-c4e29e21abd5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f9d85c3-1c5e-4914-8004-c53c7077c4a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b85fa56-9290-404b-922b-6076fa4c0975"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOUSE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d2d0edb-3e36-4815-a219-8b72f7ad7a38"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""INTERACT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""46593b37-1d1d-42af-907d-de11968d4268"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_UPDOWN"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3bfd6db7-4cc3-42c1-aad3-1157217e9faf"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_UPDOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ce7a3d55-7566-4def-bf47-8d409254a388"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_UPDOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""264cf934-aaba-47e8-8b51-430aaaeb617c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_SPEEDSLOW"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""81375375-102b-401b-b7d4-1e4de53c4e57"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_SPEEDSLOW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""71d48e1d-1ad5-4d39-9690-a682958da2b0"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE_SPEEDSLOW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ab0a8786-fcba-4fbe-b511-2b686de0920a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FIRE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CAR"",
            ""id"": ""73e3a31b-efae-4992-a826-2035c0147c6c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""1a6bb83d-9c20-453a-835f-d5be391cc45d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68ee424e-e37e-4b1e-a311-118f2d71bc09"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SPECTATOR
        m_SPECTATOR = asset.FindActionMap("SPECTATOR", throwIfNotFound: true);
        m_SPECTATOR_MOVE = m_SPECTATOR.FindAction("MOVE", throwIfNotFound: true);
        m_SPECTATOR_MOUSE = m_SPECTATOR.FindAction("MOUSE", throwIfNotFound: true);
        m_SPECTATOR_INTERACT = m_SPECTATOR.FindAction("INTERACT", throwIfNotFound: true);
        m_SPECTATOR_MOVE_UPDOWN = m_SPECTATOR.FindAction("MOVE_UPDOWN", throwIfNotFound: true);
        m_SPECTATOR_MOVE_SPEEDSLOW = m_SPECTATOR.FindAction("MOVE_SPEEDSLOW", throwIfNotFound: true);
        m_SPECTATOR_FIRE = m_SPECTATOR.FindAction("FIRE", throwIfNotFound: true);
        // CAR
        m_CAR = asset.FindActionMap("CAR", throwIfNotFound: true);
        m_CAR_Newaction = m_CAR.FindAction("New action", throwIfNotFound: true);
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

    // SPECTATOR
    private readonly InputActionMap m_SPECTATOR;
    private List<ISPECTATORActions> m_SPECTATORActionsCallbackInterfaces = new List<ISPECTATORActions>();
    private readonly InputAction m_SPECTATOR_MOVE;
    private readonly InputAction m_SPECTATOR_MOUSE;
    private readonly InputAction m_SPECTATOR_INTERACT;
    private readonly InputAction m_SPECTATOR_MOVE_UPDOWN;
    private readonly InputAction m_SPECTATOR_MOVE_SPEEDSLOW;
    private readonly InputAction m_SPECTATOR_FIRE;
    public struct SPECTATORActions
    {
        private @NewControls m_Wrapper;
        public SPECTATORActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_SPECTATOR_MOVE;
        public InputAction @MOUSE => m_Wrapper.m_SPECTATOR_MOUSE;
        public InputAction @INTERACT => m_Wrapper.m_SPECTATOR_INTERACT;
        public InputAction @MOVE_UPDOWN => m_Wrapper.m_SPECTATOR_MOVE_UPDOWN;
        public InputAction @MOVE_SPEEDSLOW => m_Wrapper.m_SPECTATOR_MOVE_SPEEDSLOW;
        public InputAction @FIRE => m_Wrapper.m_SPECTATOR_FIRE;
        public InputActionMap Get() { return m_Wrapper.m_SPECTATOR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SPECTATORActions set) { return set.Get(); }
        public void AddCallbacks(ISPECTATORActions instance)
        {
            if (instance == null || m_Wrapper.m_SPECTATORActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SPECTATORActionsCallbackInterfaces.Add(instance);
            @MOVE.started += instance.OnMOVE;
            @MOVE.performed += instance.OnMOVE;
            @MOVE.canceled += instance.OnMOVE;
            @MOUSE.started += instance.OnMOUSE;
            @MOUSE.performed += instance.OnMOUSE;
            @MOUSE.canceled += instance.OnMOUSE;
            @INTERACT.started += instance.OnINTERACT;
            @INTERACT.performed += instance.OnINTERACT;
            @INTERACT.canceled += instance.OnINTERACT;
            @MOVE_UPDOWN.started += instance.OnMOVE_UPDOWN;
            @MOVE_UPDOWN.performed += instance.OnMOVE_UPDOWN;
            @MOVE_UPDOWN.canceled += instance.OnMOVE_UPDOWN;
            @MOVE_SPEEDSLOW.started += instance.OnMOVE_SPEEDSLOW;
            @MOVE_SPEEDSLOW.performed += instance.OnMOVE_SPEEDSLOW;
            @MOVE_SPEEDSLOW.canceled += instance.OnMOVE_SPEEDSLOW;
            @FIRE.started += instance.OnFIRE;
            @FIRE.performed += instance.OnFIRE;
            @FIRE.canceled += instance.OnFIRE;
        }

        private void UnregisterCallbacks(ISPECTATORActions instance)
        {
            @MOVE.started -= instance.OnMOVE;
            @MOVE.performed -= instance.OnMOVE;
            @MOVE.canceled -= instance.OnMOVE;
            @MOUSE.started -= instance.OnMOUSE;
            @MOUSE.performed -= instance.OnMOUSE;
            @MOUSE.canceled -= instance.OnMOUSE;
            @INTERACT.started -= instance.OnINTERACT;
            @INTERACT.performed -= instance.OnINTERACT;
            @INTERACT.canceled -= instance.OnINTERACT;
            @MOVE_UPDOWN.started -= instance.OnMOVE_UPDOWN;
            @MOVE_UPDOWN.performed -= instance.OnMOVE_UPDOWN;
            @MOVE_UPDOWN.canceled -= instance.OnMOVE_UPDOWN;
            @MOVE_SPEEDSLOW.started -= instance.OnMOVE_SPEEDSLOW;
            @MOVE_SPEEDSLOW.performed -= instance.OnMOVE_SPEEDSLOW;
            @MOVE_SPEEDSLOW.canceled -= instance.OnMOVE_SPEEDSLOW;
            @FIRE.started -= instance.OnFIRE;
            @FIRE.performed -= instance.OnFIRE;
            @FIRE.canceled -= instance.OnFIRE;
        }

        public void RemoveCallbacks(ISPECTATORActions instance)
        {
            if (m_Wrapper.m_SPECTATORActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISPECTATORActions instance)
        {
            foreach (var item in m_Wrapper.m_SPECTATORActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SPECTATORActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SPECTATORActions @SPECTATOR => new SPECTATORActions(this);

    // CAR
    private readonly InputActionMap m_CAR;
    private List<ICARActions> m_CARActionsCallbackInterfaces = new List<ICARActions>();
    private readonly InputAction m_CAR_Newaction;
    public struct CARActions
    {
        private @NewControls m_Wrapper;
        public CARActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_CAR_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_CAR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CARActions set) { return set.Get(); }
        public void AddCallbacks(ICARActions instance)
        {
            if (instance == null || m_Wrapper.m_CARActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CARActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(ICARActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(ICARActions instance)
        {
            if (m_Wrapper.m_CARActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICARActions instance)
        {
            foreach (var item in m_Wrapper.m_CARActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CARActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CARActions @CAR => new CARActions(this);
    public interface ISPECTATORActions
    {
        void OnMOVE(InputAction.CallbackContext context);
        void OnMOUSE(InputAction.CallbackContext context);
        void OnINTERACT(InputAction.CallbackContext context);
        void OnMOVE_UPDOWN(InputAction.CallbackContext context);
        void OnMOVE_SPEEDSLOW(InputAction.CallbackContext context);
        void OnFIRE(InputAction.CallbackContext context);
    }
    public interface ICARActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
