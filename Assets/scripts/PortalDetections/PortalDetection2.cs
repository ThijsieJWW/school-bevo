using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDetection2 : MonoBehaviour
{
    public GameManger gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("you won lvl 2");
            gm.Lvl2_finish();
        }
    }

}
