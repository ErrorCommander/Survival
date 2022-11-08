using ExtensionsTools;
using UnityEngine;

public class Lance : Weapon
{
    private readonly Vector3 _halfExtents = new Vector3(0.2f, 0.2f, 1.2f);
    private readonly Vector3 _offset = new Vector3(0, 1f, 1.6f);
    
    private readonly Collider[] _hits = new Collider[6];
    
    public override void Attack(Transform transformAttacker)
    {
        int amountHit = BoxCheck(transformAttacker.position, _offset, transformAttacker.rotation, _halfExtents, _hits);
        if (amountHit > 0)     
            ApplyingDamage(_hits, amountHit, Damage);
    }
}