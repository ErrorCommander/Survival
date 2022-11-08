using System;
using UnityEngine;

public abstract class Weapon: BaseWeapon, IAttachable
{
    public event Action OnAttached = delegate { };
    
    public void AttachTo(Transform parent)
    {
        OnAttached.Invoke();
        this.transform.SetParent(parent);
        this.transform.localPosition = Vector3.zero;
        this.transform.localRotation = Quaternion.identity;
    }
}