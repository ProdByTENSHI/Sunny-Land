using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private int checkPointID;              // ID of Check Point in Scene
    [SerializeField] private Sprite defaultSprite;          // Sprite when not Activated
    [SerializeField] private Sprite activatedSprite;        // Sprite when Activated
    public bool hasReached;

    public Action<int> onCheckPointEnter;        // Event that gets Invoked when Player enters Checkpoint

    private void Start()
    {
        if(!hasReached)
        {
            GetComponent<SpriteRenderer>().sprite = defaultSprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(!hasReached)
            {
                onCheckPointEnter?.Invoke(checkPointID);                        // Trigger the OnCheckPointEnter Event
                hasReached = true;
                GetComponent<SpriteRenderer>().sprite = activatedSprite;        // Change Sprite from default to activated
            }
        }
    }

    public Vector2 GetSpawn()
    {
        return transform.position;
    }

    public void SetCheckPointID(int id)
    {
        checkPointID = id;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, GetComponent<CircleCollider2D>().radius);
    }
}