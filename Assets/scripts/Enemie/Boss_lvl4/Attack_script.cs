using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Attack_script : MonoBehaviour
{
    public Transform GFX;
    public Transform charge_pos;
    public Transform normal_pos;
    public float charge_time;

    public Animator animator;

    // Update is called once per frame
    void Start()
    {
        idel();
    }

    //states
    void idel()
    {
        animator.Play("idel");
        Invoke("charge_attack", 5);
    }

    void charge_attack()
    {
        animator.Play("charge");
        Invoke("back_charge_attack", 2.5f);
    }

    void back_charge_attack()
    {
        animator.Play("back_charge");
        Invoke("idel", 4f);
    }

    void basketbal_attack()
    {

    }
}
