using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraExistCheacker : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Update()
    {
        if (_camera == null)
        {
            SceneManager.LoadScene(0);
        }
    }
}
