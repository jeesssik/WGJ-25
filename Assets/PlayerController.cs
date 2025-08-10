using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    public float dashSpeed = 8f;

    private Rigidbody2D rb;
    private Animator anim;

    private bool isGrounded;
    private bool isDashing;
    private float dashTime = 0.2f;
    private float dashTimeLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        HandleDash();
        HandleAttacks();
        HandleInteractions();
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Soporta WASD y flechas

        if (!isDashing)
        {
            rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        }

        // Parámetros para el Animator
        anim.SetFloat("speed", Mathf.Abs(moveX));
        anim.SetFloat("VerticalSpeed", rb.velocity.y);
        anim.SetBool("isGrounded", isGrounded);

        // Flip sprite
        if (moveX != 0)
            transform.localScale = new Vector3(Mathf.Sign(moveX), 1, 1);
    }

    void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetTrigger("Jump");
        }
    }

    void HandleDash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            isDashing = true;
            dashTimeLeft = dashTime;
        }

        if (isDashing)
        {
            float dir = transform.localScale.x;
            rb.velocity = new Vector2(dir * dashSpeed, rb.velocity.y);

            dashTimeLeft -= Time.deltaTime;
            if (dashTimeLeft <= 0)
                isDashing = false;
        }
    }

    void HandleAttacks()
    {
        if (Input.GetKeyDown(KeyCode.J))
            anim.SetBool("isAttacking", true);
        else if (Input.GetKeyUp(KeyCode.J))
            anim.SetBool("isAttacking", false);

        if (Input.GetKeyDown(KeyCode.K))
            anim.SetBool("isRanged", true);
        else if (Input.GetKeyUp(KeyCode.K))
            anim.SetBool("isRanged", false);

        if (Input.GetKeyDown(KeyCode.L))
            anim.SetBool("isRolling", true);
        else if (Input.GetKeyUp(KeyCode.L))
            anim.SetBool("isRolling", false);
    }

    void HandleInteractions()
    {
        if (Input.GetKey(KeyCode.E))
            anim.SetBool("isPushing", true);
        else
            anim.SetBool("isPushing", false);
    }

    // Detectar si está en el suelo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
