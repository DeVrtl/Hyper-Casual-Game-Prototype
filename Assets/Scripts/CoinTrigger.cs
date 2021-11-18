using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinTrigger : MonoBehaviour
{
    [SerializeField] private CompanionMoney _companionMoney;
    [SerializeField] private int _reward;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Companion>(out Companion companion))
        {
            _companionMoney.AddMoney(_reward);
            Destroy(gameObject);
        }
    }
}
