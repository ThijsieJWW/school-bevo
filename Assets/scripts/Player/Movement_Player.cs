using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public float Move_Speed;
    public Rigidbody2D rb;

    public float JumpForce = 20f;
    public Transform GroundCheck;
    public LayerMask groundLayers;

    float mx;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)//check if nothing is pressed
        {
            mx = 0f;//set the forces to nothing
        }

        if (Input.GetKey(KeyCode.D))//check for the D button
        {
            mx = 1f;//set the forces to right
        }

        if (Input.GetKey(KeyCode.A))//check for the A button
        {
            mx = - 1f;//set the forces to left
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrouned())
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * Move_Speed, rb.velocity.y);//rekent de movemt snelheid en de directie

        rb.velocity = movement;//voert de forces uit
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, JumpForce);

        rb.velocity = movement;
    }

    public bool isGrouned()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(GroundCheck.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}
