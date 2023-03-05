using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpoint : MonoBehaviour
{
    private BoxCollider2D triggerZone;

    [SerializeField] private float reachDistance;       // Distance where the Player reaches the Endpoint

    public static Action onEndZoneReach;

    private void Start()
    {
        triggerZone = GetComponent<BoxCollider2D>();
        triggerZone.size = new Vector2(reachDistance, reachDistance);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            onEndZoneReach?.Invoke();
            SceneHandler.LoadNextScene();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(reachDistance, reachDistance, 0));
    }
}