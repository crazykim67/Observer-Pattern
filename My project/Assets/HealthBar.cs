using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth.OnHealthChanged += UpdateHealthBar;
    }

    private void UpdateHealthBar(float health)
    {
        Debug.Log($"Health Updated to {health}");
    }
}
