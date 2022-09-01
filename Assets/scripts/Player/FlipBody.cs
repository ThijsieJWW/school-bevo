using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBody : MonoBehaviour
{
    public SpriteRenderer SR;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            SR.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SR.flipX = true;   
        }
    }
}
