using System;
using UnityEngine;

[RequireComponent(typeof(Weapon))]
public class WeaponDurability : Healthy, IDestroyable
{
    public event Action OnDestroyWeapon = delegate { };
    
    [SerializeField] private float _durabilityOnHit;
    
    private Weapon _weapon;

    private void Start()
    {
        _weapon = GetComponent<Weapon>();
        _weapon.OnApplyingDamage += ReduceDurability;
        OnDeath += WeaponDestroyed;
    }

    private void WeaponDestroyed() 
        => OnDestroyWeapon.Invoke();

    private void ReduceDurability()
    {
        TakeDamage(_durabilityOnHit);
    }

    private void OnDestroy()
    {
        _weapon.OnApplyingDamage -= ReduceDurability;
        OnDeath -= WeaponDestroyed;
    }
}