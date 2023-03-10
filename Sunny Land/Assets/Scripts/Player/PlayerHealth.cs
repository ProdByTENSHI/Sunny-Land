using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamagable
{
    public static int currentHealth;
    public static int maxHealth = 10;

    public static Action onDamage;
    public static Action onDeath;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            OnDeath();
        }
    }

    public void OnDamage()
    {
        Debug.Log("Dealt Damage to Player");
        onDamage?.Invoke();
    }

    public void OnDeath()
    {
        onDeath?.Invoke();
        currentHealth = maxHealth;
        PlayerManager.points -= 5;
    }
}