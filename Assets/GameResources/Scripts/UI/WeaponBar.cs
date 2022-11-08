using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBar : MonoBehaviour
{
    [SerializeField] private WeaponContent _windowPrefab;
    [SerializeField] private WeaponInventory _inventory;

    private Dictionary<BaseWeapon, WeaponContent> _contents = new Dictionary<BaseWeapon, WeaponContent>();
    private BaseWeapon _selectedWeapon;

    private void Start() => Subscribe();

    private void OnDestroy() => Unsubscribe();

    private void Subscribe()
    {
        _inventory.OnDropWeapon += DropWeapon;
        _inventory.OnTakeWeapon += TakeWeapon;
        _inventory.OnSwitchWeapon += SwitchWeapon;
    }

    private void Unsubscribe()
    {
        _inventory.OnDropWeapon -= DropWeapon;
        _inventory.OnTakeWeapon -= TakeWeapon;
        _inventory.OnSwitchWeapon -= SwitchWeapon;
    }

    private void SwitchWeapon(BaseWeapon weapon)
    {
        if (_selectedWeapon != null && _contents.ContainsKey(_selectedWeapon))
            _contents[_selectedWeapon]?.Deselect();
        
        _contents[weapon].Select();
        _selectedWeapon = weapon;
    }

    private void TakeWeapon(BaseWeapon weapon)
    {
        WeaponContent content = Instantiate(_windowPrefab, transform);
        content.SetContent(weapon.GetComponent<WeaponInfo>());

        _contents.Add(weapon, content);
    }

    private void DropWeapon(BaseWeapon weapon)
    {
        Destroy(_contents[weapon].gameObject);
        _contents.Remove(weapon);
    }
}