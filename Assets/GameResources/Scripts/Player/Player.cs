using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerAnimator))]
public class Player : Healthy
{
    public InputSystem Input { get; private set; }

    public float Speed => _baseSpeed * _speedFactor;

    public float DamageFactor
    {
        get => _damageFactor;
        set
        {
            if (value < 0)
                _damageFactor = 0;
            else
                _damageFactor = value;
        }
    }

    public float SpeedFactor
    {
        get => _speedFactor;
        set
        {
            if (value < 0)
                _speedFactor = 0;
            else
                _speedFactor = value;
        }
    }

    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _baseSpeed = 5f;
    [SerializeField] private LayerMask _lookingLayer;

    private readonly RaycastHit[] _raycastHit = new RaycastHit[2];

    private Camera _camera;
    private float _speedFactor = 1f;
    private float _damageFactor = 1f;
    private PlayerAnimator _animator;
    private bool _isLock = false;

    private void Start() 
        => _animator = GetComponent<PlayerAnimator>();

    private void Awake()
    {
        _camera = Camera.main;
        Input = new InputSystem();
        OnDeath += Death;
    }

    public override void TakeDamage(float damage)
    {
        damage *= DamageFactor;
        base.TakeDamage(damage);
    }

    private void Death()
    {
        _animator.Death();
        Input.Disable();
        _isLock = true;
        
        OnDeath -= Death;
    }

    private void Update()
    {
        Vector3 gravity = Vector3.zero; 
        if (!_characterController.isGrounded)
        {
            gravity = Vector3.down;
        }
        Vector3 inputAxis = Input.Player.Move.ReadValue<Vector2>().AsVector3XZ();
        
        PlayerLookAtMouse();
        if (inputAxis.sqrMagnitude != 0 || Speed == 0)
        {
            _characterController.Move(Speed * Time.deltaTime * (inputAxis + gravity));
            _animator.OnMoveAnimation(inputAxis, _characterController.transform.rotation, Speed);
        }
        else
        {
            _animator.EndMoveAnimation();
        }
    }

    private void PlayerLookAtMouse()
    {
        if (!_isLock)
        {
            Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());
            //if (Physics.RaycastNonAlloc(ray, _raycastHit, 50f, _lookingLayer) != 0) // не возвращает ближайший объект
            if (Physics.Raycast(ray, out _raycastHit[0], 50f, _lookingLayer))
            {
                _characterController.transform.rotation = LookRotation(_raycastHit[0].point);
            }
        }
    }

    private Quaternion LookRotation(Vector3 lookPoint)
    {
        Vector3 directional = (lookPoint - _characterController.transform.position).ChangeY(0);
        return Quaternion.LookRotation(directional);
    }

    private void OnEnable() 
        => Input.Enable();

    private void OnDisable() 
        => Input.Disable();
}