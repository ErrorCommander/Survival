using ExtensionsTools;
using UnityEngine;

[RequireComponent(typeof(Player), (typeof(PlayerAnimator)))]
public class PlayerAttack : MonoBehaviour, IAttacker
{
    private const float FORWARD_OFFSET = 0.9f;
    private const float UP_OFFSET = 1.3f;
    private const float RADIUS_CECK = 0.2f;
    
    [SerializeField] private LayerMask _layerAttack;
    
    private readonly int _animatorAttack = Animator.StringToHash("Attack");
    private PlayerAnimator _animator;
    
    private Player _player;
    private InputSystem _input;

    private void Start()
    {
        _animator = GetComponent<PlayerAnimator>();
        _player = GetComponent<Player>();
        _input = _player.Input;
        _input.Player.Attack.performed += context => TryAttack();
    }

    private void TryAttack()
    {
        Debug.Log("Try Attack");
        if (!_animator.IsBlock)
        {
            _animator.PlayAnimation(_animatorAttack);
        }
    }

    public void OnAttack()
    {
        Debug.Log("End Attack");

        Vector3 hitPoint = transform.position;
        hitPoint += transform.rotation * (Vector3.forward * FORWARD_OFFSET);
        hitPoint += transform.rotation * (Vector3.up * UP_OFFSET);
        float radius = RADIUS_CECK;
        Collider[] hits = new Collider[1];

        if (Physics.OverlapSphereNonAlloc(hitPoint, radius, hits, _layerAttack) != 0)
        {
            Debug.Log(hits[0].name);
        }
        else
        {
            Debug.Log("did not hit");
        }

        DebugTools.DrawSpark(hitPoint, radius, 5f);
    }
}