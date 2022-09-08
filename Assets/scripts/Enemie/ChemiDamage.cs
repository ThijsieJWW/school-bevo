using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemiDamage : MonoBehaviour
{
    GameManger gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Health healt = other.GetComponent<Health>();

            if (healt != null)
            {
                healt.TakeDamage(3);
            }
        }
    }
}
