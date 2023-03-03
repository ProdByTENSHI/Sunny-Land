using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : MonoBehaviour, ICollectible
{
    private Animator _anim;
    [SerializeField] private string id;             // Unique ID of the Item; Used for Saving and Loading
    [SerializeField] private int points;            // Amount of Points you get when collecting the Item

    public static Action<string> onCollect;         // Triggers On Collect with ID

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        if(id == null)
        {
            id = System.Guid.NewGuid().ToString();
        }
    }

    public void OnCollect()
    {
        PlayerManager.points += this.points;
        _anim.SetTrigger("Collect");
        Destroy(gameObject, _anim.GetCurrentAnimatorStateInfo(0).length);
        FindObjectOfType<AudioManager>().Play("Collect");
        onCollect?.Invoke(id);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) {
            OnCollect();
        }
    }

    public string GetID()
    {
        return id;
    }
}