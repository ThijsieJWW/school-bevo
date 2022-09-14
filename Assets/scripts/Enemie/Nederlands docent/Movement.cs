using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(speed, 0, 0));
    }
}
