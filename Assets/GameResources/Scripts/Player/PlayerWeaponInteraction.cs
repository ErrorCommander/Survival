using UnityEngine;

[RequireComponent(typeof(PlayerAttack))]
[RequireComponent(typeof(WeaponInventory))]
[RequireComponent(typeof(Player))]
public class PlayerWeaponInteraction: MonoBehaviour
{
    private const float DETECT_RADIUS = 1.2f;

    public LayerMask LayerMask;
    
    private readonly Collider[] _overlapHits = new Collider[1];
    
    private InputSystem _input;
    private WeaponInventory _inventory;
    private PlayerAttack _attaker;

    private void Start()
    {
        _attaker = GetComponent<PlayerAttack>();
        _inventory = GetComponent<WeaponInventory>();
        _input = GetComponent<Player>().Input;
        _input.Player.PickUp.performed += context => PickUp();
        _input.Player.Drop.performed += context => Drop();
        SubscribeSwitchWeapon();
        _attaker.SetWeapon(_inventory.GetFirstOrDefaultWeapon());
    }

    private void SubscribeSwitchWeapon()
    {
        _input.Player.SwitchWeaponTo1.performed += context => SwitchWeapon(0);
        _input.Player.SwitchWeaponTo2.performed += context => SwitchWeapon(1);
        _input.Player.SwitchWeaponTo3.performed += context => SwitchWeapon(2);
        _input.Player.SwitchWeaponTo4.performed += context => SwitchWeapon(3);
        _input.Player.SwitchWeaponTo5.performed += context => SwitchWeapon(4);
    }

    private void Drop() 
        => _attaker.SetWeapon(_inventory.DropWeapon());

    private void PickUp()
    {
        if (!_inventory.IsFull)
        {
             var size = Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, DETECT_RADIUS, _overlapHits,LayerMask);
                
            if (size != 0)
            {
                _overlapHits[0].enabled = false;
                BaseWeapon weapon = _overlapHits[0].GetComponent<BaseWeapon>();
                if(weapon == null)
                    return;

                if (_inventory.TryPutWeapon(weapon))
                {
                    _attaker.SetWeapon(weapon);
                    
                    IDestroyable destroyable = weapon.GetComponent<IDestroyable>();
                    if (destroyable != null)
                        destroyable.OnDestroyWeapon += WeaponDestroyed;
                }
            }
        }
    }
    
    private void WeaponDestroyed() 
        => Drop();

    private void SwitchWeapon(int index)
    {
        BaseWeapon weapon = _inventory.GetWeapon(index);
        
        if (weapon != null) 
            _attaker.SetWeapon(weapon);
    }
}