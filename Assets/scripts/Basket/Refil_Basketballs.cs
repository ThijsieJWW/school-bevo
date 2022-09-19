using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refil_Basketballs : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            other.GetComponent<Basket_ball_combatSystem>().BasketBall_refill();
        }
    }
}
