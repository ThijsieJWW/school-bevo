using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(4, 4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(4, 4, 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-4, 4, 1);
        }
    }
}
