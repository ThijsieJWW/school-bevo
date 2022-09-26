using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int Maxhealth = 3;
    int currentHealth;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Maxhealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        rb.AddForce(new Vector2(-25, 50));

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}