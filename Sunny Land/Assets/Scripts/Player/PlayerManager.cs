using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public static int points;

    public void Spawn(Vector2 spawnPosition)
    {
        transform.position = spawnPosition;
    }
}