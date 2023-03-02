using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public static int health;
    public static int points;
    private static int maxHealth = 10;

    public static Action onDeath;

    private void Awake()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if(health == 0)
        {
            onDeath?.Invoke();
            Destroy(gameObject);
        }
    }
}