using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDetection_3 : MonoBehaviour
{
    public GameManger gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.onFinish();
        }
    }

}
