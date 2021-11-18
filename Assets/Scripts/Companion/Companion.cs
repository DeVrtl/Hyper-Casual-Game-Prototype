using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deathEffect;
    [SerializeField] private float _xOffset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Car>(out Car car))
        {
            Instantiate(_deathEffect, transform.position, Quaternion.Euler(_xOffset, transform.position.y, transform.position.z));
            Destroy(gameObject);
        }
    }
}
