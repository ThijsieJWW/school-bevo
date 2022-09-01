using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public Transform start;
    public Rigidbody2D rb;

    public float MoveSpeed = 10;
    public float JumpForce = 5;

    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Left_moving();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Right_moving();
        }

        if (Input.GetKey(KeyCode.W) && isJumping == false)
        {
            Jump();
        }
    }

    void Left_moving()
    {
        rb.AddForce(new Vector2(-MoveSpeed, 0));
    }

    void Right_moving()
    {
        rb.AddForce(new Vector2(MoveSpeed, 0));
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, JumpForce));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}
