using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    
    private static readonly int _run = Animator.StringToHash("Run");
    private bool _isTriggerSet;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        
        if (horizontalAxis > 0 || horizontalAxis < 0)
        {
            if (!_isTriggerSet)
            {
                _animator.SetTrigger(_run);
                _isTriggerSet = true;
            }
        
            float translation = Input.GetAxis("Horizontal") * _speed;
        
            _spriteRenderer.flipX = horizontalAxis < 0;
        
            transform.Translate(translation * Time.deltaTime, 0, 0);
        }

        if (horizontalAxis == 0)
        {
            if (_isTriggerSet)
            {
                _animator.SetTrigger(_run);
                _isTriggerSet = false;
            }
        }
    }
}
