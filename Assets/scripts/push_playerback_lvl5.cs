using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_playerback_lvl5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Movement_Player>().can_move_right = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<Movement_Player>().can_move_right = false;
    }
}
