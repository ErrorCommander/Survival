using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offsetPosition;
    [SerializeField] private bool _usePositionAsOffset;

    private void Awake()
    {
        if (_usePositionAsOffset)
        {
            _offsetPosition = transform.position;
        }
    }

    private void LateUpdate()
    {
        transform.position = _target.position + _offsetPosition;
    }
}
