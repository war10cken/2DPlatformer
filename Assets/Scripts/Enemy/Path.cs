using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5f, PathType.Linear, PathMode.Sidescroller2D)
                               .SetOptions(true)
                               .SetLookAt(0.01f);
        
        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}
