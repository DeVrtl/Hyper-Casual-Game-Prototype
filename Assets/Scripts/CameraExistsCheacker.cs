using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class CameraExistsCheacker : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Update()
    {
        if (_camera == null)
        {
            Game.Load();
        }
    }
}
