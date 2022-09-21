using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burster : MonoBehaviour
{
    // Start is called before the first frame update
    private float Timer;
    public ParticleSystem ps;

    void Start()
    {
        Timer = .0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > 6.0f)
        {
            Timer = .0f;
            Burst();
        }
    }

    void Burst()
    {
        ps.Play();
    }
}
