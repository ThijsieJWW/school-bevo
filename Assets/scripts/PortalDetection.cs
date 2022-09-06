using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalDetection : MonoBehaviour
{
    public GameManger gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("you won lvl 1");
            gm.Lvl1_finish();
        }
    }
}
