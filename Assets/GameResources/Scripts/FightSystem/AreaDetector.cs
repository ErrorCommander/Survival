using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AreaDetector : MonoBehaviour
{
    public event Action<Transform> OnEnterArea = delegate {  };
    public event Action<Transform> OnExitArea = delegate {  };
    
    private void OnTriggerEnter(Collider other) 
        => OnEnterArea.Invoke(other.transform);

    private void OnTriggerExit(Collider other) 
        => OnExitArea.Invoke(other.transform);
}