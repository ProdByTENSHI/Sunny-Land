using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private CheckPoint[] checkPoints;
    [SerializeField] private int lastCheckPoint;     // ID of last Check Point

    private void OnEnable()
    {
        checkPoints = FindObjectsOfType<CheckPoint>();
        for(int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].SetCheckPointID(i);
            checkPoints[i].onSpawnEnter += SetLastCheckPoint;
            Debug.Log("Check Point " + i + " found");
        }
    }

    private void SetLastCheckPoint()
    {
        for (int i = 0; i < checkPoints.Length; ++i)
        {
            if (checkPoints[i].hasReached)
            {
                lastCheckPoint = i;
                Debug.Log("New Checkpoint: " + lastCheckPoint);
            }
        }
    }

    private void SpawnAtCheckPoint(int id)
    {
        FindObjectOfType<PlayerManager>().Spawn(checkPoints[id].GetSpawn());
    }
}