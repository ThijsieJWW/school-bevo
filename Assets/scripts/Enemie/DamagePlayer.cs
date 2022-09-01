using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int Damage = 1;
    public float Distance = 1.1f;
    public LayerMask playerLayer;

    // Update is called once per frame
    void Update()
    {
       RaycastHit2D hit_right;
       if (hit_right = Physics2D.Raycast(transform.position, transform.right, Distance, playerLayer))
       {
            Health health = hit_right.transform.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(Damage);
            }
       }

        RaycastHit2D hit_left;
        if (hit_left = Physics2D.Raycast(transform.position, -transform.right, Distance, playerLayer))
        {
            Health health = hit_left.transform.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(Damage);
            }
        }
    }

    public void die()
    {
        Destroy(gameObject);
    }
}
