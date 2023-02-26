using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    // BASIC MOVEMENT
    [SerializeField] private float movSpeed = 5f;
    private float horInput;
    private bool isFacingRight;

    // JUMPING
    [SerializeField] private float jumpVelocity;
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float groundCheckRadius = 0.5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask whatIsGround;
    private bool onGround { get; set; }

    public delegate void OnJump();
    public static event OnJump onJump;

    // CROUCHING
    [SerializeField] float crouchSlow = 2f;
    private bool _isCrouching;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        horInput = Input.GetAxisRaw("Horizontal");
    }

    private void Update()
    {
        HandleMovement();
        HandleJumping();
    }

    private void HandleMovement()
    {
        // Basic Movement
        transform.Translate(new Vector2(horInput * movSpeed, 0) * Time.deltaTime);
        if(isFacingRight && horInput > 0)
        {
            FlipCharacterFacing();
        } else if(!isFacingRight && horInput < 0)
        {
            FlipCharacterFacing();
        }

        // Crouching
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            _isCrouching = true;
            movSpeed /= crouchSlow;
        } else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            _isCrouching = false;
            movSpeed *= crouchSlow;
        }
    }

    private void HandleJumping()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            _rb.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
            onJump?.Invoke();
        }

        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private void FlipCharacterFacing()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    public float GetHorizontalInput()
    {
        return horInput;
    }

    public float GetVerticalVelocity()
    {
        return _rb.velocity.y;
    }

    public bool isCrouching()
    {
        return _isCrouching;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}