using System;
using System.Collections;
using System.Collections.Generic;
using Spawners;
using UnityEngine;

public class OpossumSpawner : BasicSpawner
{
    private void Start()
    {
        if (_template.TryGetComponent(out Enemy enemy))
        {
            StartCoroutine(SpawnEntity(enemy, 1));
        }
    }
}
