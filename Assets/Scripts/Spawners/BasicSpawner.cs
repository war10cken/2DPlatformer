using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Spawners
{
    public abstract class BasicSpawner : MonoBehaviour
    {
        [SerializeField] protected GameObject _template;

        protected IEnumerator SpawnEntity<T>(T entity, int count)
         where T : MonoBehaviour
        {
            for (int i = 0; i < count; i++)
            {
                Vector3 spawnPosition = transform.position + new Vector3(i, 0, 0);
                Instantiate(entity, spawnPosition, Quaternion.identity);

                yield return null;
            }
        }
    }
}