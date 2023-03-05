using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private CheckPoint[] checkPoints;      // Array with all Checkpoints in Scene
    public static int currentCheckPoint;                  // ID of last Check Point

    private void OnEnable()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].SetCheckPointID(i);
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

    private void SetLastCheckPoint(int id)
    {
        currentCheckPoint = id;
    }

    public CheckPoint GetCheckPoint(int id)
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

    public CheckPoint[] GetCheckPoints()
    {
        return checkPoints;
    }
}