using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 _offset;

    private void Update()
    {
        transform.position = new Vector3(_player.position.x + _offset.x, _player.position.y + _offset.y, -10);
    }
}
