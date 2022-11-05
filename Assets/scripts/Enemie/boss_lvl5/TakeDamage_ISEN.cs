using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TakeDamage_ISEN : MonoBehaviour
{
    //basic health stats
    public int Max_hp = 150;
    public int Min_hp = 0;
    public int current_hp;

    // Start is called before the first frame update
    void Start()
    {
        //set the current hp correct
        current_hp = Max_hp;
    }

    public void takeDamage(int damage)
    {
        current_hp -= damage;

        if (current_hp <= Min_hp)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
