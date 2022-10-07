using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieBasket_ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forwardForce;
    public float upForce;
    public int Damage = 1;

    private void Start()
    {
        rb.AddForce(Time.deltaTime * new Vector3(forwardForce * 50, upForce * 50, 0));
        Invoke("delete_basketbal", 5f);
    }

    void delete_basketbal()
    {
        Destroy(gameObject);
    }
}
