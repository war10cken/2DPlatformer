using System;
using System.Collections;
using System.Collections.Generic;
using Spawners;
using UnityEngine;
using Random = UnityEngine.Random;

public class GemSpawner : BasicSpawner
{
    private int _count;

    private void Awake()
    {
        _count = Random.Range(1, 11);
    }

    private void Start()
    {
        if (_template.TryGetComponent(out Gem gem))
        {
            StartCoroutine(SpawnEntity(gem, _count));
        }
    }
}
