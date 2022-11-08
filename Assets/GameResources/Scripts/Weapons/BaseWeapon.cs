using System;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour, IWeapon
{
    public float Damage => _damage;
    public float Delay => _delay;
    public WeaponType WeaponType => _weaponType;
    public event Action OnApplyingDamage = delegate { };

    [SerializeField, Range(0, 50)] private float _damage = 10f;
    [SerializeField, Range(0, 3)] private float _delay = 1f;
    [SerializeField] private WeaponType _weaponType = WeaponType.Fist;
    [SerializeField] private LayerMask _attackLayer;

    public abstract void Attack(Transform transformAttacker);

    protected void ApplyingDamage(Collider[] hits, int count, float damage)
    {
        IDamageable damageable;
        OnApplyingDamage.Invoke();
        for (int i = 0; i < count; i++)
        {
            if (hits[i].TryGetComponent<IDamageable>(out damageable)) 
                damageable.TakeDamage(damage);
        }
    }
    
    protected void ApplyingDamage(RaycastHit[] hits, int count, float damage)
    {
        IDamageable damageable;
        OnApplyingDamage.Invoke();
        for (int i = 0; i < count; i++)
        {
            if (hits[i].transform.TryGetComponent<IDamageable>(out damageable)) 
                damageable.TakeDamage(damage);
        }
    }

    protected void LogHits(Collider[] hits, int count)
    {
        if (count != 0)
            Debug.Log("did not hit");
        else
        {
            for (int i = 0; i < count; i++)
            {
                Debug.Log(hits[i].name);
            }
        }
    }

    protected void LogHits(RaycastHit[] hits, int count)
    {
        if (count == 0)
            Debug.Log("did not hit");
        else
        {
            for (int i = 0; i < count; i++)
            {
                Debug.Log(hits[i].collider.name);
            }
        }
    }

    protected int BoxCheck(Vector3 center, Vector3 offset, Quaternion rotation, Vector3 halfExtents, Collider[] hits) 
        => Physics.OverlapBoxNonAlloc(CenterWithOffset(center, offset, rotation), halfExtents,  hits, rotation, _attackLayer);

    protected int SphereCheck(Vector3 center, Vector3 offset, Quaternion rotation, float radius, Collider[] hits) 
        => Physics.OverlapSphereNonAlloc(CenterWithOffset(center, offset, rotation), radius, hits, _attackLayer);

    protected int LineCheck(Vector3 center, Vector3 offset, Quaternion rotation, float radius, RaycastHit[] hits)
    {
        Vector3 directional = rotation * Vector3.forward * radius;

        return Physics.RaycastNonAlloc(CenterWithOffset(center, offset, rotation), directional, hits, radius, _attackLayer);
    }
    
    private Vector3 CenterWithOffset(Vector3 center, Vector3 offset, Quaternion rotation) 
        => center + rotation * offset;
}