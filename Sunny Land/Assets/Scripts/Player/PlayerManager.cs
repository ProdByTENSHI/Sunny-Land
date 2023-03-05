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
        SpawnAtCheckPoint(CheckPointManager.currentCheckPoint);
    }

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

    public void SpawnAtCheckPoint(int id)
    {
        FindObjectOfType<PlayerManager>().Spawn(new Vector2(checkPointManager.GetCheckPoints()[id].GetSpawn().x, checkPointManager.GetCheckPoints()[id].GetSpawn().y + 5));
    }
}