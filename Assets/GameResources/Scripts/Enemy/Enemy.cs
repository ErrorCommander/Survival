using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Enemy : Healthy, IAnimAttacker
{
    [SerializeField] private Vector3 _centerAttackArea = new Vector3(0, 1.3f, 0.8f);
    [SerializeField] private float _radiusChekDamade = 0.4f;
    [SerializeField] private float _damage = 10f;
    [SerializeField] private LayerMask _attackLayer;

    private readonly Collider[] _hits = new Collider[1];

    public void OnAttack()
    {
        int count = SphereCheck(transform.position, _centerAttackArea, transform.rotation, _radiusChekDamade, _hits);
        if (count != 0)
        {
            IDamageable damageable;
            if (_hits[0].TryGetComponent<IDamageable>(out damageable))
                damageable.TakeDamage(_damage);
        }
    }

    private int SphereCheck(Vector3 center, Vector3 offset, Quaternion rotation, float radius, Collider[] hits) 
        => Physics.OverlapSphereNonAlloc(CenterWithOffset(center, offset, rotation), radius, hits, _attackLayer);

    private Vector3 CenterWithOffset(Vector3 center, Vector3 offset, Quaternion rotation) 
        => center + rotation * offset;
}