using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemie : MonoBehaviour
{
    bool canSpawn = true;
    public GameObject Enemie;
    public float SecondsWait = 5f;
    private void Update()
    {
        if (canSpawn == true)
        {
            Instantiate(Enemie, transform.position, transform.rotation);
            canSpawn = false;
            Invoke("ResetTimer", SecondsWait);
        }
    }

    void ResetTimer()
    {
        canSpawn = true;
    }
}
