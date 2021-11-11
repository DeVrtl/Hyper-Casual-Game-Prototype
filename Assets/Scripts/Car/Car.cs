using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Deactivator>(out Deactivator deactivator))
        {
            gameObject.SetActive(false);
        }
    }
}
