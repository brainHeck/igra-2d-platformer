using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Animator animator;

    private float horizontal;
    private float speed = 5f;
    private float jumpingPower = 10f;
    private bool isFacingRight = true;

    void Update()
    {
        //proverava na koju stranu je okrenut lik i da li treba da se okrene
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        animator.SetFloat("speed", Math.Abs(horizontal));

        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        //proverava da li dodiruje zemlju i zapocinje skok
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        //proverava da li je igrac kompletno zadrzao space ili je pustio
        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    { // koristi se za proveru da li je na zemlji tako sto proverava da li groundCheck dodiruje ground layer objekata
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {//okrece lika
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {//koristi gotov paket kako bi pomerao lika
        horizontal = context.ReadValue<Vector2>().x;
    }
}
