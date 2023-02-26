using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private float movSpeed = 5f;
    [SerializeField] private float jumpVelocity;
    [SerializeField] private float groundCheckRadius = 0.5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask whatIsGround;

    private float horInput;
    private bool isFacingRight;
    private bool onGround { get; set; }

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

        // Jumping
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            _rb.AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
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

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}