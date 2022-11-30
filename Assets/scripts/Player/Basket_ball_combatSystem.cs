using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_ball_combatSystem : MonoBehaviour
{   
    //basket ball counters
    public int current_basketBall = 0;
    public int max_basketBall = 5;

    //basket bal texts
    public Text max_basketball_txt;
    public Text current_basketball_txt;

    //the basketbal/point to shoot refrence
    public GameObject Basketball;
    public Transform pointToShoot;

    // Start is called before the first frame update
    void Start()
    {
        current_basketBall = 0;
        if (max_basketball_txt != null)
        {
            max_basketball_txt.text = max_basketBall.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (current_basketBall >= 1 && Input.GetKeyDown(KeyCode.Q))
        {
            shootBall();        
        }
        if (current_basketball_txt != null)
        {
            current_basketball_txt.text = current_basketBall.ToString();
        }
    }

    void shootBall()
    {
        Instantiate(Basketball, pointToShoot.position, transform.rotation);
        current_basketBall--;
    }

    public void BasketBall_refill()
    {
        current_basketBall = 5;
        Debug.Log("Basket balls reffiled");
    }
}
