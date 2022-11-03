using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISENDOORN_script : MonoBehaviour
{
    //trow object
    public GameObject trow_object;
    public Rigidbody2D trow_object_rigidboy;
    //attackpoint
    public Transform attack_point;

    // Start is called before the first frame update
    void Start()
    {
        //trow object rigidbody
        trow_object_rigidboy = trow_object.GetComponent<Rigidbody2D>();
        Invoke("Attack1", 2);
    }

    void Attack1()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
    }
}
