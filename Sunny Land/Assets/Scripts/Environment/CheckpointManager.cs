using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private CheckPoint[] checkPoints;      // Array with all Checkpoints in Scene
    public static int currentCheckPoint;                    // ID of last Check Point

    private void OnEnable()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].SetCheckPointID(i);                      // Set ID of found Check Points
            checkPoints[i].onCheckPointEnter += SetLastCheckPoint;       // Subscribe to On Spawn Enter Event to get last Checkpoint
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].onCheckPointEnter -= SetLastCheckPoint;       // Unsubscribe from Event
        }
    }

    private void SetLastCheckPoint(int id)
    {
        currentCheckPoint = id;
    }

    // Get Checkpoint by ID
    public CheckPoint GetCheckPoint(int id)
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            if(i == id)
            {
                return checkPoints[i];
            }
        }

        return null;
    }

    // Get all Checkpoints
    public CheckPoint[] GetCheckPoints()
    {
        return checkPoints;
    }
}