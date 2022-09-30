using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall_script : MonoBehaviour
{
    //refrence to the rigidbody 2D and calling it rb
    public Rigidbody2D rb;
    //forward and upward forces
    public float forwardForce = 5;
    public float upwardForce = 5f;
    //the damage wen it colides with the boss
    public int damage = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Time.deltaTime * new Vector3(forwardForce * 50, upwardForce * 50, 0));
        Invoke("delete_bassketball", 1.5f);
    }

    void delete_bassketball()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("boss"))
        {
            other.collider.GetComponent<TakeDamage>().takeDamage(damage);
        }
    }
}
