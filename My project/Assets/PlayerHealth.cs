using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<float> OnHealthChanged;

    [SerializeField]
    private float health;

    public void ChangeHealth(float amount)
    {
        health += amount;
        OnHealthChanged?.Invoke(health);
    }
}
