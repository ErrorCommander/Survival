using ExtensionsTools;
using UnityEngine;

public class Sword : Weapon
{
    private readonly Vector3 _halfExtents = new Vector3(0.9f, 0.7f, 0.4f);
    private readonly Vector3 _offset = new Vector3(0, 1f, 0.6f);
    
    private readonly Collider[] _hits = new Collider[10];
    
    public override void Attack(Transform transformAttacker)
    {
        int amountHit = BoxCheck(transformAttacker.position, _offset, transformAttacker.rotation, _halfExtents, _hits);
        if (amountHit > 0) 
            ApplyingDamage(_hits, amountHit, Damage);
    }
}