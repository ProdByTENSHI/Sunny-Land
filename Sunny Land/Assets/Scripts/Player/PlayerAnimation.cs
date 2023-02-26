using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _anim;
    private SpriteRenderer _sr;
    private PlayerController _controller;

    [SerializeField] private Sprite jumpSprite;
    [SerializeField] private Sprite fallSprite;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
        _controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        HandleAnimations();
        HandleJumping();
    }

    private void HandleAnimations()
    {
        // Use Horizontal Input to determine Running State and convert to positive Value if the Input is negative
        float _running = _controller.GetHorizontalInput();
        if(_running < 0)
        {
            _running *= -1;
        }

        _anim.SetFloat("Running_F", _running);

        // Jumping and Falling

        // Crouching
        _anim.SetBool("isCrouching", _controller.isCrouching());
    }

    private void HandleJumping()
    {
        if (_controller.GetVerticalVelocity() > 0)
        {
            _anim.enabled = false;
            _sr.sprite = jumpSprite;
        }
        else if (_controller.GetVerticalVelocity() < 0)
        {
            _anim.enabled = false;
            _sr.sprite = fallSprite;
        }
        else if (_controller.GetVerticalVelocity() == 0)
        {
            _anim.enabled = true;
        }
    }
}