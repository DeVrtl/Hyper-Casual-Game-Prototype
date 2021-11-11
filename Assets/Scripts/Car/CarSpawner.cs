using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : ObjectPool
{
    [SerializeField] private GameObject _templates;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawns;

    private float _elapsedTime = 0;

    private void Start()
    {
        Init(_templates);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawns)
        {
            if (TryGetObject(out GameObject car))
            {
                _elapsedTime = 0;

                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

                SetCar(car, _spawnPoints[spawnPointNumber].position);
            }
        }
    }

    private void SetCar(GameObject car, Vector3 spawnPoint)
    {
        car.SetActive(true);
        car.transform.position = spawnPoint;
    }
}
