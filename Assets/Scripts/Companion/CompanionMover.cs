using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class CompanionMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private Animator _animator;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector3.forward * _speed * Time.deltaTime;
            _animator.Play(AnimationCompanionController.States.Run);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            _rigidbody.velocity = Vector3.zero;
            _animator.Play(AnimationCompanionController.States.Idle);
        }
    }
}
