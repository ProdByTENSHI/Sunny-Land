using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private CheckPointManager checkPointManager;
    public static int points;

    private void Start()
    {
        checkPointManager = FindObjectOfType<CheckPointManager>();

        PlayerHealth.onDeath += SpawnAtCurrentCheckPoint;
    }

    private void Update()
    {
        // Cap Points at Zero
        if(points < 0)
        {
            points = 0;
        }
    }

    // Spawn at Vector2 Position; Y Coords always with +2.18 to prevent Player from Clipping in Ground
    public void Spawn(Vector2 spawnPosition)
    {
        transform.position = new Vector2(spawnPosition.x, spawnPosition.y + 2.18f);
    }

    // Spawn at a Checkpoint with the given Check Point ID
    public void SpawnAtCheckPoint(int id)
    {
        FindObjectOfType<PlayerManager>().Spawn(new Vector2(checkPointManager.GetCheckPoints()[id].GetSpawn().x, checkPointManager.GetCheckPoints()[id].GetSpawn().y + 2.18f));
    }

    // Spawn at current CheckPoint
    public void SpawnAtCurrentCheckPoint()
    {
        FindObjectOfType<PlayerManager>().Spawn(new Vector2(checkPointManager.GetCheckPoint(CheckPointManager.currentCheckPoint).GetSpawn().x, checkPointManager.GetCheckPoint(CheckPointManager.currentCheckPoint).GetSpawn().y + 2.18f));
    }
}