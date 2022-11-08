using UnityEngine;

public class WeaponSpawnPoint : SpawnPoint<Weapon>
{
    private Weapon _weapon;

    private void Start() 
        => OnSpawn += SpawnWeapon;

    private void OnDestroy() 
        => OnSpawn -= SpawnWeapon;
    
    private void SpawnWeapon(Weapon weapon)
    {
        _weapon = weapon;
        weapon.OnAttached += PikeUpWeapon;
    }

    private void PikeUpWeapon()
    {
        _weapon.OnAttached -= PikeUpWeapon;
        ReadySpawn();
    }
}