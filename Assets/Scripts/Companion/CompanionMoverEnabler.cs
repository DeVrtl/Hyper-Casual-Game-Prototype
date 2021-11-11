using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionMoverEnabler : MonoBehaviour
{
    [SerializeField] private CompanionMover[] _movers;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Companion>(out Companion companion))
        {
            for (int i = 0; i < _movers.Length; i++)
            {
                _movers[i].enabled = true;
            }
        }
    }
}
