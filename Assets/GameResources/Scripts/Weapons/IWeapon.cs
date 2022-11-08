using UnityEngine;

public interface IWeapon
{
    public float Damage { get; }
    public float Delay { get; }
    public WeaponType WeaponType { get; } 
    public void Attack(Transform transformAttacker);
}