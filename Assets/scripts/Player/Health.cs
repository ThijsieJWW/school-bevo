using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    int currentHealth;
    public int minHp = 0;
    public int maxHp = 0;
    public Slider hp_slider;
    public GameManger gameManger;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHp;
        hp_slider.maxValue = maxHp;
        hp_slider.minValue = minHp;
    }

    private void Update()
    {
        hp_slider.value = currentHealth;
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