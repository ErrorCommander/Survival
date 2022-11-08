using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Player), typeof(PlayerAnimator))]
public class PlayerAttack : MonoBehaviour, IAnimAttacker
{
    [SerializeField] private Transform _attachPoint;

    private readonly int _animatorAttack = Animator.StringToHash("Attack");
    private readonly int _animatorShot = Animator.StringToHash("BowShot");

    private BaseWeapon _weapon;
    private PlayerAnimator _animator;
    private Player _player;
    private InputSystem _input;
    private bool _isCanAttack = true;

    public void SetWeapon(BaseWeapon weapon)
    {
        if (_isCanAttack)
        {
            if(_weapon != null)
                _weapon.gameObject.SetActive(false);
            
            _weapon = weapon;
            _weapon.gameObject.SetActive(true);
            AttachWeapon(_weapon);
            _animator.SetWeapon(_weapon.WeaponType);
        }
        else
        {
            StartCoroutine(DelaySwitchWeapon(weapon));
        }
    }

    public void OnAttack()
    {
            _weapon.Attack(transform);
        _player.SpeedFactor = 1f;
    }

    private void Awake() => _animator = GetComponent<PlayerAnimator>();

    private void Start()
    {
        _player = GetComponent<Player>();
        _input = _player.Input;
        _input.Player.Attack.performed += context => TryAttack();
    }

    private void AttachWeapon(BaseWeapon weapon)
    {
        if (weapon is IAttachable attachable)
            attachable.AttachTo(_attachPoint);
    }

    private IEnumerator DelaySwitchWeapon(BaseWeapon weapon)
    {
        yield return new WaitUntil(() => _isCanAttack);
        SetWeapon(weapon);
    }

    private void TryAttack()
    {
        if (!_animator.IsBlock && _isCanAttack)
        {
            if (_weapon.WeaponType == WeaponType.Bow)
            {
                _player.SpeedFactor = 0.5f;
                _animator.PlayAnimation(_animatorShot);
            }
            else
            {
                _animator.PlayAnimation(_animatorAttack);
            }
            
            DelayAttack(_weapon.Delay);
        }
    }

    private void DelayAttack(float delay) 
        => StartCoroutine(BlockedAttack(delay));

    private IEnumerator BlockedAttack(float delay)
    {
        _isCanAttack = false;
        yield return new WaitForSeconds(delay);
        _isCanAttack = true;
    }
}