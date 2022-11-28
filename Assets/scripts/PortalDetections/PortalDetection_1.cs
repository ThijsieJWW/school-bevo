using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalDetection_1 : MonoBehaviour
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
