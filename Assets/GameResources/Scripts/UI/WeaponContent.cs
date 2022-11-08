using System;
using UnityEngine;
using UnityEngine.UI;

public class WeaponContent : MonoBehaviour
{
    [SerializeField] private HealthbarHandler _healthBar;
    [SerializeField] private Image _iconPlace;
    [SerializeField] private Image _selectMark;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private Color _unselectedColor;

    public void SetContent(WeaponInfo weapon)
    {
        _healthBar.SetTarget(weapon.Durability);
        _iconPlace.sprite = weapon.Icon;
        Deselect();
    }

    public void Select() => _selectMark.color = _selectedColor;

    public void Deselect() => _selectMark.color = _unselectedColor;
}
