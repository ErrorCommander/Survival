using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] private List<Weapon> _spawnedWeapons;
    [SerializeField, Range(0f, 20f)] private float _spawnDelaySeconds = 5f;
    
    private WeaponSpawnPoint[] _spawnPosition;

    private void Start()
    {
        _spawnPosition = FindObjectsOfType<WeaponSpawnPoint>();

        foreach (var spawnPoint in _spawnPosition)
        {
            spawnPoint.OnReadySpawn += SpawnWeapon;
            spawnPoint.Spawn(GetRandomWeapon());
        }   
    }

    private void SpawnWeapon(ISpawner<Weapon> spawner) 
        => StartCoroutine(DelaySpawn(spawner, _spawnDelaySeconds));

    private IEnumerator DelaySpawn(ISpawner<Weapon> spawner, float delay)
    {
        yield return new WaitForSeconds(delay);
        spawner.Spawn(GetRandomWeapon());
    }

    private Weapon GetRandomWeapon() 
        => _spawnedWeapons[Random.Range(0, _spawnedWeapons.Count)];
}