using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour
{

    float dirX;

    public float moveSpeed = 5f;
    public float jumpForce = 700f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            doJump();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    public void doJump()
    {
        if (rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }
    }

}
