using UnityEngine;

public interface ISpawner<TValue> where TValue : Component
{
    public void Spawn<T>(T prefab) where T : TValue;
}