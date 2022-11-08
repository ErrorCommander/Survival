using UnityEngine;

public class Bow : Weapon
{
    private const float DISTANCE_ATTACK = 15f;
    
    private readonly Vector3 _offset = new Vector3(0, 1.3f, 0.2f);
    private readonly RaycastHit[] _hits = new RaycastHit[1];
    
    public override void Attack(Transform transformAttacker)
    {
        int amountHit = LineCheck(transformAttacker.position, _offset, transformAttacker.rotation, DISTANCE_ATTACK, _hits);
        if (amountHit > 0) 
            ApplyingDamage(_hits, amountHit, Damage);
    }
}