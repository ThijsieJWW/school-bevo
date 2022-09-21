using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall_script : MonoBehaviour
{
    //refrence to the rigidbody 2D and calling it rb
    public Rigidbody2D rb;
    //forward and upward forces
    public float forwardForce = 7.5f;
    public float upwardForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Time.deltaTime * new Vector3(forwardForce * 50, upwardForce * 50, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
