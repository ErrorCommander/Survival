using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarHandler : MonoBehaviour
{
    [SerializeField] private Healthy _target;
    [SerializeField] private HealthBar _healthBar;

    public void SetTarget(Healthy target)
    {
        _target = target;
        Start();
    }
    
    private void Start()
    {
        if (_target != null)
        {
            Refresh(_target.PartHealth);
            _target.OnHealthChanged += Refresh;
        }
    }

    private void Refresh(float partHealth) 
        => _healthBar.ChangeValue(partHealth);

    private void OnDestroy()
    {
        if (_target != null)
            _target.OnHealthChanged -= Refresh;
    }
}