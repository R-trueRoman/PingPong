// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""MainActionMap"",
            ""id"": ""e206275e-2c7c-4034-9107-a87dcddfed78"",
            ""actions"": [
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Value"",
                    ""id"": ""8a24eb63-f447-472f-9731-0ce3a900738d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop"",
                    ""type"": ""Button"",
                    ""id"": ""412f1f83-92f0-4ec8-abf2-9bcd5aa83488"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7d842194-c91f-4423-9577-a0d4509e8fce"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9a00199-ea4f-4e1f-a9ae-f1246e6f67b3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bfc4d3e7-403b-4b14-95e8-ca24001f6e5f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b9d4412-c474-4dd7-b3fd-870ece2fd914"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SecondMap"",
            ""id"": ""45502055-6b1d-4058-a43d-e99aad16e833"",
            ""actions"": [
                {
                    ""name"": ""UpDown2"",
                    ""type"": ""Button"",
                    ""id"": ""baa878e4-b630-477c-8fa0-afe27dd558af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ba095bc0-3bbb-4fb5-902c-4596328994f4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1495912b-a2c9-456c-9ed4-59be99c5e3c6"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c632a7ea-230d-4c1c-a3d5-34ea71fa8319"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainActionMap
        m_MainActionMap = asset.FindActionMap("MainActionMap", throwIfNotFound: true);
        m_MainActionMap_UpDown = m_MainActionMap.FindAction("UpDown", throwIfNotFound: true);
        m_MainActionMap_Stop = m_MainActionMap.FindAction("Stop", throwIfNotFound: true);
        // SecondMap
        m_SecondMap = asset.FindActionMap("SecondMap", throwIfNotFound: true);
        m_SecondMap_UpDown2 = m_SecondMap.FindAction("UpDown2", throwIfNotFound: true);
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

    // MainActionMap
    private readonly InputActionMap m_MainActionMap;
    private IMainActionMapActions m_MainActionMapActionsCallbackInterface;
    private readonly InputAction m_MainActionMap_UpDown;
    private readonly InputAction m_MainActionMap_Stop;
    public struct MainActionMapActions
    {
        private @NewControls m_Wrapper;
        public MainActionMapActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UpDown => m_Wrapper.m_MainActionMap_UpDown;
        public InputAction @Stop => m_Wrapper.m_MainActionMap_Stop;
        public InputActionMap Get() { return m_Wrapper.m_MainActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IMainActionMapActions instance)
        {
            if (m_Wrapper.m_MainActionMapActionsCallbackInterface != null)
            {
                @UpDown.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnUpDown;
                @Stop.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnStop;
                @Stop.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnStop;
                @Stop.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnStop;
            }
            m_Wrapper.m_MainActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @Stop.started += instance.OnStop;
                @Stop.performed += instance.OnStop;
                @Stop.canceled += instance.OnStop;
            }
        }
    }
    public MainActionMapActions @MainActionMap => new MainActionMapActions(this);

    // SecondMap
    private readonly InputActionMap m_SecondMap;
    private ISecondMapActions m_SecondMapActionsCallbackInterface;
    private readonly InputAction m_SecondMap_UpDown2;
    public struct SecondMapActions
    {
        private @NewControls m_Wrapper;
        public SecondMapActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UpDown2 => m_Wrapper.m_SecondMap_UpDown2;
        public InputActionMap Get() { return m_Wrapper.m_SecondMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SecondMapActions set) { return set.Get(); }
        public void SetCallbacks(ISecondMapActions instance)
        {
            if (m_Wrapper.m_SecondMapActionsCallbackInterface != null)
            {
                @UpDown2.started -= m_Wrapper.m_SecondMapActionsCallbackInterface.OnUpDown2;
                @UpDown2.performed -= m_Wrapper.m_SecondMapActionsCallbackInterface.OnUpDown2;
                @UpDown2.canceled -= m_Wrapper.m_SecondMapActionsCallbackInterface.OnUpDown2;
            }
            m_Wrapper.m_SecondMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UpDown2.started += instance.OnUpDown2;
                @UpDown2.performed += instance.OnUpDown2;
                @UpDown2.canceled += instance.OnUpDown2;
            }
        }
    }
    public SecondMapActions @SecondMap => new SecondMapActions(this);
    public interface IMainActionMapActions
    {
        void OnUpDown(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
    }
    public interface ISecondMapActions
    {
        void OnUpDown2(InputAction.CallbackContext context);
    }
}
