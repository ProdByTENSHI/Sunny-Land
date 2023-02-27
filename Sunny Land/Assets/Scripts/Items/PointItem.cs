using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : MonoBehaviour, ICollectible
{
    private Animator _anim;
    [SerializeField] private int points;            // Amount of Points you get when collecting the Item

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void OnCollect()
    {
        PlayerManager.AddPoints(points);
        _anim.SetTrigger("Collect");
        Destroy(gameObject, _anim.GetCurrentAnimatorStateInfo(0).length);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) {
            OnCollect();
        }
    }
}