using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int Maxhealth = 3;
    int minhealth = 0;
    int currentHealth;
    public Rigidbody2D rb;
    public Slider health_slider;

    private void Update()
    {
        health_slider.value = currentHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Maxhealth;

        health_slider.maxValue = Maxhealth;
        health_slider.minValue = minhealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

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