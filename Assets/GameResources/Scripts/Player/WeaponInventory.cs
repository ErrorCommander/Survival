using System;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    private const int INVENTORY_SIZE = 5;

    public event Action<BaseWeapon> OnDropWeapon = delegate { };
    public event Action<BaseWeapon> OnTakeWeapon = delegate { };
    public event Action<BaseWeapon> OnSwitchWeapon = delegate { }; 
    
    public bool IsFull => _countWeapons >= INVENTORY_SIZE;
    
    [SerializeField] private BaseWeapon _defaultWeapon;
    
    private readonly BaseWeapon[] _weapons = new BaseWeapon[INVENTORY_SIZE];
    private int _selectedWeapon = -1;
    private int _countWeapons = 0;

    public BaseWeapon GetFirstOrDefaultWeapon()
    {
        CheckWeapons();

        if (_countWeapons > 0)
            return GetWeapon(0);

        return _defaultWeapon;
    }

    /// <summary>
    /// Get weapon by index.
    /// </summary>
    /// <param name="index">Weapon index.</param>
    /// <returns>Return null else not found weapon by index.</returns>
    public BaseWeapon GetWeapon(int index)
    {
        if (index < _countWeapons)
        {
            _selectedWeapon = index;
            OnSwitchWeapon.Invoke(_weapons[_selectedWeapon]);
            return _weapons[_selectedWeapon];
        }

        return null;
    }

    /// <summary>
    /// Remove current weapons.
    /// </summary>
    /// <returns>Return first weapon of default.</returns>
    public BaseWeapon DropWeapon()
    {
        if (_selectedWeapon == -1)
            return _defaultWeapon;
        
        OnDropWeapon.Invoke(_weapons[_selectedWeapon]);
        RemoveWeapon(_selectedWeapon);

        return GetFirstOrDefaultWeapon();
    }

    public bool TryPutWeapon(BaseWeapon weapon)
    {
        if (!IsFull)
        {
            _weapons[_countWeapons] = weapon;
            _selectedWeapon = _countWeapons++;
            OnTakeWeapon.Invoke(weapon);
            OnSwitchWeapon.Invoke(weapon);

            return true;
        }

        return false;
    }   


    private void CheckWeapons()
    {
        for (int i = _countWeapons - 1; i >= 0; i--)
        {
            if (_weapons[i] == null)
                RemoveWeapon(i);
        }
    }

    private void RemoveWeapon(int index)
    {
        _countWeapons--;
        if(_weapons[index] != null)
            Destroy(_weapons[index].gameObject);
        
        for (int i = index + 1; i < INVENTORY_SIZE; i++)
        {
            _weapons[i - 1] = _weapons[i];
        }

        _weapons[INVENTORY_SIZE - 1] = null;
    }
}
