using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _anim;
    private PlayerController _controller;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        HandleAnimations();
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
    }
}