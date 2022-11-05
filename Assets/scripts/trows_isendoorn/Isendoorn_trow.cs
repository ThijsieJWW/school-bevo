using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isendoorn_trow : MonoBehaviour
{
    //forces
    public int minForce;
    public int maxForce;
    //refrence to rigidbody
    public Rigidbody2D rb;
    //multiplier
    public float multiplir = 1250;

    // Start is called before the first frame update
    void Start()
    {
        pickrandomnumber(maxForce, minForce);
    }

    private void pickrandomnumber(int maxint, int minint)
    {
        int randomNum = Random.Range(minint+1, maxint+1);
        rb.AddForce(Time.deltaTime * new Vector3(-randomNum * multiplir, randomNum * multiplir, 0));
        Debug.Log(randomNum);
        Invoke("Delete", 3f);
    }

    private void Delete()
    {
        Destroy(gameObject);
    }
}
