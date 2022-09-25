using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour
{
    //basic health stats
    public int Max_hp = 150;
    public int Min_hp = 0;
    public int current_hp;
    //refrence to the health slider
    public Slider hp_slider;
    //refrence to game manger
    public GameManger gamemanger;

    // Start is called before the first frame update
    void Start()
    {
        //set the current hp correct
        current_hp = Max_hp;
        //set the slider values
        hp_slider.maxValue = Max_hp;
        hp_slider.minValue = Min_hp;
    }

    // Update is called once per frame
    void Update()
    {
        //update the slider when the hp is lower
        hp_slider.value = current_hp;
    }

    public void takeDamage(int damage)
    {
        current_hp -= damage;

        if (current_hp <= Min_hp)
        {
            Die();
        }
    }

    void Die()
    {
        gamemanger.Lvl4_finish();
    }
}
