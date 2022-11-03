using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private LayerMask _visibleLayerForPlayer;

    public Animator animator;

    private InputSystem _input;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        _input = new InputSystem();
        SubscribeInputActions();
    }

    private void Update()
    {
        Vector3 inputAxis = _input.Player.Move.ReadValue<Vector2>().AsVector3XZ();
        _characterController.Move(_speed * Time.deltaTime * inputAxis);
        PlayerLookAtMouse();
        SetAnimatorVariables(inputAxis);
    }   

    private void SetAnimatorVariables(Vector3 inputAxis)
    {
        animator.SetFloat("Speed", inputAxis.magnitude * _speed);
        Quaternion rotation = _characterController.transform.rotation.ChangeY(-_characterController.transform.rotation.y);
        Vector3 rotatedAxis = rotation * inputAxis;
        animator.SetFloat("X", rotatedAxis.x);
        animator.SetFloat("Y", rotatedAxis.z);
    }
    
    private void PlayerLookAtMouse()
    {
        Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 1000f, _visibleLayerForPlayer))
        {
            _characterController.transform.rotation = LookRotation(hit.point);
        }
    }

    private Quaternion LookRotation(Vector3 lookPoint)
    {
        Vector3 directional = (lookPoint - _characterController.transform.position).ChangeY(0);
        return Quaternion.LookRotation(directional);
    }

    private void SubscribeInputActions()
    {
        _input.Player.Attack.performed += context => Attack();
        _input.Player.Block.performed += context => Block();
        _input.Player.Drop.performed += context => Drop();
        _input.Player.PickUp.performed += context => PickUp();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Attack()
    {
        Debug.Log("Attack");
    }

    private void Block()
    {
        Debug.Log("Block");
    }

    private void Drop()
    {
        Debug.Log("Drop");
    }

    private void PickUp()
    {
        Debug.Log("PickUp");
    }
}
