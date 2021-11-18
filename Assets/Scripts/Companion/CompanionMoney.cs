using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CompanionMoney : MonoBehaviour
{
    public int Money { get; private set; }

    public event UnityAction<int> MoneyChanged;

    public void AddMoney(int money)
    {
        Money += money;
        MoneyChanged?.Invoke(Money);
    }
}
