using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Enemy))]
public class EnemyBehaviour : MonoBehaviour
{
    private readonly int _animatorAttack = Animator.StringToHash("IsAttack");
    private readonly int _animatorDie = Animator.StringToHash("Death");
    private readonly int _animatorSpeed = Animator.StringToHash("Speed");
    
    [SerializeField] private AreaDetector _followArea;
    [SerializeField] private AreaDetector _attackArea;
    [SerializeField] private float _speed;
    [SerializeField] private Collider _collider;

    private Animator _animator;
    private Enemy _enemy;
    private NavMeshAgent _agent;
    private Coroutine _coroutineFollow;
    private Transform _target;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _animator = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = _speed;

        Subscribe();
    }

    private void OnDestroy() => Unsubscribe();

    private void Subscribe()
    {
        _enemy.OnDeath += Die;
        _followArea.OnEnterArea += FollowTo;
        _attackArea.OnEnterArea += Attack;
        _attackArea.OnExitArea += FollowTo;
    }
    
    private void Unsubscribe()
    {
        _enemy.OnDeath -= Die;
        _followArea.OnEnterArea -= FollowTo;
        _attackArea.OnEnterArea -= Attack;
        _attackArea.OnExitArea -= FollowTo;
    }
    
    private void Die()
    {
        Unsubscribe();
        
        _animator.SetBool(_animatorAttack, false);
        _animator.SetFloat(_animatorSpeed, 0);
        _animator.Play(_animatorDie);
        _agent.isStopped = true;
        _collider.enabled = false;

        Destroy(gameObject, 2.5f);
    }

    private void EndAttackAnimation()
    {
        if (_target != null)
            transform.LookAt(_target);
        else
            EndAttack();
    }

    private void Attack(Transform target)
    {
        StopCoroutine(_coroutineFollow);
        transform.LookAt(target);
        LerpStopMove(target);
        _animator.SetBool(_animatorAttack, true);
    }

    private void FollowTo(Transform target)
    {
        _target = target;
        _animator.SetBool(_animatorAttack, false);
        if (_target == null)
            EndAttack();
        
        _coroutineFollow = StartCoroutine(Follow(target));
    }

    private void EndAttack()
    {
        _animator.SetBool(_animatorAttack, false);
        _agent.destination = transform.position;
    }

    private void LerpStopMove(Transform target)
    {
        _agent.destination = Vector3.Lerp( target.position, transform.position, 0.8f);
        _animator.SetFloat(_animatorSpeed, 0);
    }

    private IEnumerator Follow(Transform target)
    {
        _animator.SetFloat(_animatorSpeed, _agent.speed);
        
        while (target != null && target.gameObject.activeSelf)
        {
            _agent.destination = target.position;
            yield return new WaitForSeconds(Time.deltaTime * 5);
        }
        
        _animator.SetFloat(_animatorSpeed, 0);
        _agent.destination = transform.position;
    }
}
