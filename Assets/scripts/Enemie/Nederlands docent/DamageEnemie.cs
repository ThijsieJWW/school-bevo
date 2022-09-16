using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Health health = other.gameObject.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(3);
            }
        }
    }
}
