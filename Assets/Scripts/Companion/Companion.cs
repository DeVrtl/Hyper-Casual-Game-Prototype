using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Companion : MonoBehaviour
{
    [SerializeField] ParticleSystem _deathEffect;
    [SerializeField] float _xOffset;

    public int Money { get; private set; }

    public event UnityAction<int> MoneyChanged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Car>(out Car car))
        {
            Instantiate(_deathEffect, transform.position, Quaternion.Euler(_xOffset, transform.position.y, transform.position.z));
            Destroy(gameObject);
        }
    }

    public void AddMoney(int money)
    {
        Money += money;
        MoneyChanged?.Invoke(Money);
    }
}
