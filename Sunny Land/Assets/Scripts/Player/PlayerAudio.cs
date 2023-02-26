using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private PlayerController _controller;

    private void Start()
    {
        PlayerController.onJump += HandleJumping;
    }

    private void OnDisable()
    {
        PlayerController.onJump -= HandleJumping;
    }

    private void HandleJumping()
    {
        FindObjectOfType<AudioManager>().Play("Jump");
    }
}