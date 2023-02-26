using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject interactionPopUp;
    private bool isInRange;

    private void Start()
    {
        interactionPopUp.SetActive(false);
    }

    public void OnInteract()
    {
        Debug.Log("Interact");
    }


    public void OnInRange()
    {
        interactionPopUp.SetActive(true);
        isInRange = true;
    }

    public void OnOutOfRange()
    {
        interactionPopUp.SetActive(false);
        isInRange = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            OnInRange();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            OnOutOfRange();
        }
    }

    public bool IsInRange()
    {
        return isInRange;
    }
}