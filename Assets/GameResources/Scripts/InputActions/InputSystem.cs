//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/GameResources/Scripts/InputActions/InputSystem.inputactions
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

public partial class @InputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e157fa30-86c3-497b-bdb7-443dc325f1ab"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""76e0affd-06cf-4fb3-9c8d-73fa766359d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c7fa656d-913b-441d-86d0-8d887bb1ce66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""c9533689-0d9a-462a-bb5b-cb8506e3a2b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EndBlock"",
                    ""type"": ""Button"",
                    ""id"": ""50b933c6-c5a5-40de-9ad6-671cdfe18203"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""6c5dc851-aaee-4ce2-878b-6811640abe7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""27b80425-bad0-4546-ab45-2504c2cbdd20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeaponTo1"",
                    ""type"": ""Button"",
                    ""id"": ""e7009f83-63f8-44cb-8089-ca6e01605d45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeaponTo2"",
                    ""type"": ""Button"",
                    ""id"": ""a9c9fcfd-3770-42ba-b02d-9bebd51723a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeaponTo3"",
                    ""type"": ""Button"",
                    ""id"": ""a00e5e41-0c9d-4eb9-b967-43e24498e5cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeaponTo4"",
                    ""type"": ""Button"",
                    ""id"": ""9d583118-ffe7-47e1-9563-594daaf37d89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeaponTo5"",
                    ""type"": ""Button"",
                    ""id"": ""6a55b0ee-6d61-471c-a7a1-36e111a84317"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91e0a82b-0ed6-47c6-a41f-2b2feb2fc25e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57257b55-c3a0-4094-b64a-9b64fc46c9b0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5990010b-f296-4a03-bd29-d8ee7b59f56b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc06ad8e-e4c3-498c-891b-023a4a2de243"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6c313355-072c-469b-b403-b1442e4fa685"",
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
                    ""id"": ""0620dd98-58cb-4fbb-83bc-93a3a9504ca8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4223f7eb-bca2-4b93-b29c-2ef6b7bda777"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ea17bd8-3bd0-4926-8a91-5998a4d9bd28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""45e6a6c9-0655-4978-a1d3-7201c449bd02"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""aa36657c-6c90-4b84-8e1e-d910b2ede5ea"",
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
                    ""id"": ""b61cc710-d016-4d30-bd63-e7b91b5f4d2b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""466bf2df-3db8-4e46-89ce-ee822fb89ca1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e73d3b3d-56bf-4864-917d-1b5e1f9001a2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5a8be26-8b5a-4a53-863b-ca394b8c0eee"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""50de7582-a7dd-4b00-8251-a1d98c2f0b89"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""EndBlock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b666dc4f-55c3-4ce8-87bd-1486f978ac1b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchWeaponTo1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08372fa4-50a9-404c-b800-293a862f93b6"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponTo1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19f5e3d7-7dbf-4549-b3cf-2eb3f589fc07"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchWeaponTo2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba56e30c-eb13-40b2-896f-35916bf6ce28"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponTo2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a9f7afc-4ffc-44c4-9b3d-c09a53f1290d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchWeaponTo3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a68eb10-75a6-43aa-810a-d6a0422ef04d"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponTo3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3727861a-6977-4268-a8f7-62fe6684fa98"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchWeaponTo4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15d47aa0-d0ea-499e-93f5-5cf84179c798"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponTo4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c49dbd7-8e4d-4279-80a8-7903a5b555b9"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchWeaponTo5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db265056-73af-467f-8261-9a91c5fa0d22"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeaponTo5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
        m_Player_EndBlock = m_Player.FindAction("EndBlock", throwIfNotFound: true);
        m_Player_PickUp = m_Player.FindAction("PickUp", throwIfNotFound: true);
        m_Player_Drop = m_Player.FindAction("Drop", throwIfNotFound: true);
        m_Player_SwitchWeaponTo1 = m_Player.FindAction("SwitchWeaponTo1", throwIfNotFound: true);
        m_Player_SwitchWeaponTo2 = m_Player.FindAction("SwitchWeaponTo2", throwIfNotFound: true);
        m_Player_SwitchWeaponTo3 = m_Player.FindAction("SwitchWeaponTo3", throwIfNotFound: true);
        m_Player_SwitchWeaponTo4 = m_Player.FindAction("SwitchWeaponTo4", throwIfNotFound: true);
        m_Player_SwitchWeaponTo5 = m_Player.FindAction("SwitchWeaponTo5", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_Block;
    private readonly InputAction m_Player_EndBlock;
    private readonly InputAction m_Player_PickUp;
    private readonly InputAction m_Player_Drop;
    private readonly InputAction m_Player_SwitchWeaponTo1;
    private readonly InputAction m_Player_SwitchWeaponTo2;
    private readonly InputAction m_Player_SwitchWeaponTo3;
    private readonly InputAction m_Player_SwitchWeaponTo4;
    private readonly InputAction m_Player_SwitchWeaponTo5;
    public struct PlayerActions
    {
        private @InputSystem m_Wrapper;
        public PlayerActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @Block => m_Wrapper.m_Player_Block;
        public InputAction @EndBlock => m_Wrapper.m_Player_EndBlock;
        public InputAction @PickUp => m_Wrapper.m_Player_PickUp;
        public InputAction @Drop => m_Wrapper.m_Player_Drop;
        public InputAction @SwitchWeaponTo1 => m_Wrapper.m_Player_SwitchWeaponTo1;
        public InputAction @SwitchWeaponTo2 => m_Wrapper.m_Player_SwitchWeaponTo2;
        public InputAction @SwitchWeaponTo3 => m_Wrapper.m_Player_SwitchWeaponTo3;
        public InputAction @SwitchWeaponTo4 => m_Wrapper.m_Player_SwitchWeaponTo4;
        public InputAction @SwitchWeaponTo5 => m_Wrapper.m_Player_SwitchWeaponTo5;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Block.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @EndBlock.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndBlock;
                @EndBlock.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndBlock;
                @EndBlock.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndBlock;
                @PickUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @Drop.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrop;
                @SwitchWeaponTo1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo1;
                @SwitchWeaponTo1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo1;
                @SwitchWeaponTo1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo1;
                @SwitchWeaponTo2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo2;
                @SwitchWeaponTo2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo2;
                @SwitchWeaponTo2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo2;
                @SwitchWeaponTo3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo3;
                @SwitchWeaponTo3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo3;
                @SwitchWeaponTo3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo3;
                @SwitchWeaponTo4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo4;
                @SwitchWeaponTo4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo4;
                @SwitchWeaponTo4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo4;
                @SwitchWeaponTo5.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo5;
                @SwitchWeaponTo5.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo5;
                @SwitchWeaponTo5.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchWeaponTo5;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @EndBlock.started += instance.OnEndBlock;
                @EndBlock.performed += instance.OnEndBlock;
                @EndBlock.canceled += instance.OnEndBlock;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @SwitchWeaponTo1.started += instance.OnSwitchWeaponTo1;
                @SwitchWeaponTo1.performed += instance.OnSwitchWeaponTo1;
                @SwitchWeaponTo1.canceled += instance.OnSwitchWeaponTo1;
                @SwitchWeaponTo2.started += instance.OnSwitchWeaponTo2;
                @SwitchWeaponTo2.performed += instance.OnSwitchWeaponTo2;
                @SwitchWeaponTo2.canceled += instance.OnSwitchWeaponTo2;
                @SwitchWeaponTo3.started += instance.OnSwitchWeaponTo3;
                @SwitchWeaponTo3.performed += instance.OnSwitchWeaponTo3;
                @SwitchWeaponTo3.canceled += instance.OnSwitchWeaponTo3;
                @SwitchWeaponTo4.started += instance.OnSwitchWeaponTo4;
                @SwitchWeaponTo4.performed += instance.OnSwitchWeaponTo4;
                @SwitchWeaponTo4.canceled += instance.OnSwitchWeaponTo4;
                @SwitchWeaponTo5.started += instance.OnSwitchWeaponTo5;
                @SwitchWeaponTo5.performed += instance.OnSwitchWeaponTo5;
                @SwitchWeaponTo5.canceled += instance.OnSwitchWeaponTo5;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnEndBlock(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnSwitchWeaponTo1(InputAction.CallbackContext context);
        void OnSwitchWeaponTo2(InputAction.CallbackContext context);
        void OnSwitchWeaponTo3(InputAction.CallbackContext context);
        void OnSwitchWeaponTo4(InputAction.CallbackContext context);
        void OnSwitchWeaponTo5(InputAction.CallbackContext context);
    }
}
