using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemieMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Move_Speed = 100f;
    public float despawn_time = 2f;

    private void Start()
    {
        Invoke("despawn", despawn_time);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(-Move_Speed, 0));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    void despawn()
    {
        Destroy(gameObject);
    }
}
