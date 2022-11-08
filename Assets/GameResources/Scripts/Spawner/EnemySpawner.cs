using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> _spawnUnits;
    [SerializeField, Range(0f, 10f)] private float _spawnDelaySeconds = 3f;
    
    private EnemySpawnPoint[] _spawnPosition;

    private void Start()
    {
        _spawnPosition = FindObjectsOfType<EnemySpawnPoint>();

        foreach (var spawnPoint in _spawnPosition)
        {
            spawnPoint.OnReadySpawn += SpawnUnit;
            spawnPoint.Spawn(GetRandomEnemy());
        }   
    }

    private void SpawnUnit(ISpawner<Enemy> spawner) 
        => StartCoroutine(DelaySpawn(spawner, _spawnDelaySeconds));

    private IEnumerator DelaySpawn(ISpawner<Enemy> spawner, float delay)
    {
        yield return new WaitForSeconds(delay);
        spawner.Spawn(GetRandomEnemy());
    }

    private Enemy GetRandomEnemy() 
        => _spawnUnits[Random.Range(0, _spawnUnits.Count)];
}