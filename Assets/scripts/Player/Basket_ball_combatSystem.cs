using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_ball_combatSystem : MonoBehaviour
{
    public int current_basketBall = 0;
    public int max_basketBall = 5;

    public Text max_basketball_txt;
    public Text current_basketball_txt;

    // Start is called before the first frame update
    void Start()
    {
        current_basketBall = 0;
        max_basketball_txt.text = max_basketBall.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (current_basketBall >= 1 && Input.GetKeyDown(KeyCode.Q))
        {
            shootBall();        
        }

        current_basketball_txt.text = current_basketBall.ToString();
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
