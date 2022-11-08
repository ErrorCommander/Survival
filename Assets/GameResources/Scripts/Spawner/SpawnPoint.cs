using System;
using UnityEngine;

public abstract class SpawnPoint<TValue> : MonoBehaviour, ISpawner<TValue> where TValue : Component
{
    public event Action<ISpawner<TValue>> OnReadySpawn = delegate { };
    public event Action<TValue> OnSpawn = delegate { }; 
    
    [SerializeField] private Color _colorMark = new Color(1f, 1f, 0f, 0.5f);

    public void Spawn<T>(T prefab) where T : TValue
    {
        T component = Instantiate(prefab);
        component.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
        OnSpawn.Invoke(component);
    }

    protected void ReadySpawn() 
        => OnReadySpawn.Invoke(this);

    private void OnDrawGizmos()
    {
        Gizmos.color = _colorMark;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}