using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player player))
        {
            AudioSource.PlayClipAtPoint(_audioClip, transform.position);
            Destroy(gameObject);
        }
    }
}
