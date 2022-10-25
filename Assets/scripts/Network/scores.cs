using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PostScore(String name, int score){
        var url = "https://schoolbevo.pythonanywhere.com/post";
        WebRequest.Create(url);
    }
}
