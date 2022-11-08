using System;
using UnityEngine;

public abstract class Healthy : MonoBehaviour, IDamageable
{
    public bool IsDeath => _currentHealth <= 0;
    public float PartHealth => _currentHealth / _maxHealth;
    
    public event Action OnDeath = delegate { };
    public event Action<float> OnHealthChanged = delegate { };

    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;
    
    public virtual void TakeDamage(float damage)
    {
        if (_currentHealth < 0)
            return;
        
        damage = damage > 0 ? damage : 0;

        _currentHealth -= damage;
        
        if (IsDeath)
        {
            OnDeath.Invoke();
            _currentHealth = 0;
        }
        
        OnHealthChanged.Invoke(PartHealth);
    }
}
