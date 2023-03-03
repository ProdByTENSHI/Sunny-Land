using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private CheckPoint[] checkPoints;      // Array with all Checkpoints in Scene
    private CheckPoint[] reachedCheckPoints;
    public static int currentCheckPoint = -1;                  // ID of last Check Point
    public int lastCheckPoint_;

    private void OnEnable()
    {
        PlayerHealth.onDeath += () => SpawnAtCheckPoint(currentCheckPoint);
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].onSpawnEnter += SetLastCheckPoint;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].onSpawnEnter -= SetLastCheckPoint;
        }
    }

    private void SetLastCheckPoint()
    {
        if (currentCheckPoint < checkPoints.Length)
        {
            currentCheckPoint++;
        }
    }

    private void SpawnAtCheckPoint(int id)
    {
        FindObjectOfType<PlayerManager>().Spawn(new Vector2(checkPoints[id].GetSpawn().x, checkPoints[id].GetSpawn().y + 5));
        Debug.Log("Player spawned at " + id);
    }

    private CheckPoint GetCheckPoint(int id)
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            if(i == id)
            {
                return checkPoints[i];
            }
        }

        return new CheckPoint();
    }
}