using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_ball_combatSystem : MonoBehaviour
{
    public int current_basketBall = 0;
    public int max_basketBall = 5;

    // Start is called before the first frame update
    void Start()
    {
        current_basketBall = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (current_basketBall >= 1 && Input.GetKeyDown(KeyCode.Q))
        {
            shootBall();        }
    }

    void shootBall()
    {
        Debug.Log("Basket ball shooted");
        current_basketBall--;
    }

    public void BasketBall_refill()
    {
        current_basketBall = 5;
        Debug.Log("Basket balls reffiled");
    }
}
