using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket_ball_combatSystem : MonoBehaviour
{
    int current_basketBall = 0;
    int max_basketBall = 5;

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
            shootBall();
            Debug.Log("1 basket ball shooted");
        }
    }

    void shootBall()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("basket") && Input.GetKeyDown(KeyCode.E) && current_basketBall <= 4)
        {
            current_basketBall += 5;
        }
    }
}
