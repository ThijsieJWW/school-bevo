using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemieMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Move_Speed = 100f;

    bool right = true;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(2, 1, 1);
    }

    private void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (right == true)
        {
            rb.AddForce(new Vector2(Move_Speed, 0));
        }

        if (right == false)
        {
            rb.AddForce(new Vector2(-Move_Speed, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall") && right == true)
        {
            right = false;
        }
        else
        {
            right = true;
        }
    }
}
