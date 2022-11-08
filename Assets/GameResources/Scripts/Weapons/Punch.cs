using ExtensionsTools;
using UnityEngine;

public class Punch : BaseWeapon
{
    private const float RADIUS_CHECK = 0.25f;
    
    private readonly Vector3 _offset = new Vector3(0, 1.3f, 0.8f);
    private readonly Collider[] _hits = new Collider[1];
    
    public override void Attack(Transform transformAttacker)
    {
        int amountHit = SphereCheck(transformAttacker.position, _offset, transformAttacker.rotation, RADIUS_CHECK, _hits);
        if (amountHit > 0) 
            ApplyingDamage(_hits, amountHit, Damage);
    }
}