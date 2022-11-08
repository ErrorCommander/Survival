using System;
using UnityEngine;

public class EnemySpawnPoint : SpawnPoint<Enemy>
{
    private Enemy _enemy;

    private void Awake() 
        => OnSpawn += SpawnedUnit;

    private void OnDestroy() 
        => OnSpawn -= SpawnedUnit;

    private void SpawnedUnit(Enemy enemy)
    {
        _enemy = enemy;
        enemy.OnDeath += EnemyDeath;
    }

    private void EnemyDeath()
    {
        _enemy.OnDeath -= EnemyDeath;
        ReadySpawn();
    }
}