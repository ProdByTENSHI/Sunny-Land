using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public static int points;

    private void Update()
    {
        // Cap Points at Zero
        if(points < 0)
        {
            points = 0;
        }
    }

    public void Spawn(Vector2 spawnPosition)
    {
        transform.position = new Vector2(spawnPosition.x, spawnPosition.y + 2.5f);
        Debug.Log("Player Spaned at " + spawnPosition);
    }
}