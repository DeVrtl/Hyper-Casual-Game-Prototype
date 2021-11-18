using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _money; 
    [SerializeField] private CompanionMoney _companionMoney;

    private void OnEnable()
    {
        _companionMoney.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _companionMoney.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}
