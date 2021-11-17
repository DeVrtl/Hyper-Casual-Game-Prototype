using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
    }

    private void Start()
    {
        _gameOverGroup.alpha = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Companion>(out Companion companion))
        {
            Time.timeScale = 0;
            _gameOverGroup.alpha = 1;
        }
    }

    private void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        Game.Load();
    }
}
