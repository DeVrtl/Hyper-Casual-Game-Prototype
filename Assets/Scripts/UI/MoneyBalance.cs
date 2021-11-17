using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _money; 
    [SerializeField] private Companion _companion;

    private void OnEnable()
    {
        _companion.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _companion.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}
