using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    private static int health;
    private static int maxHealth = 10;

    private static int points;

    public static UnityEvent onPointChange;
    public static UnityEvent<int> onHealthChange;
    public static UnityEvent onDeath;

    private void Awake()
    {
        health = maxHealth;
        if (onDeath == null)
            onDeath = new UnityEvent();

        if(onHealthChange == null)
            onHealthChange = new UnityEvent<int>();

        if (onPointChange == null)
            onPointChange = new UnityEvent();
    }

    private void Update()
    {
        if(health == 0)
        {
            onDeath?.Invoke();
            Destroy(gameObject);
        }
    }

    public static void SetHealth(int amount)
    {
        health = amount;
        onHealthChange?.Invoke(amount);
    }

    public static int GetHealth()
    {
        return health;
    }

    public static void AddPoints(int amount)
    {
        points = amount;
        onPointChange?.Invoke();
    }
}