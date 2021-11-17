using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<CarDeactivator>(out CarDeactivator deactivator))
        {
            gameObject.SetActive(false);
        }
    }
}
