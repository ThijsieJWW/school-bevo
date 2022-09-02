using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            other.GetComponent<Score_Scripts>().Score_update();
            Destroy(gameObject);
        }
    }
}
