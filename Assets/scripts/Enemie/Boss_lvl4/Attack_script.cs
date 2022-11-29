using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class Attack_script : MonoBehaviour
{
    public Transform GFX;
    public float charge_time;

    public Animator animator;

    bool isCharging = false;

    public GameObject basketbal;
    public Transform point_to_shoot;

    // Update is called once per frame
    void Start()
    {
        idel();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && isCharging == true)
        {
            other.collider.GetComponent<Health>().TakeDamage(1);
            print("we hit the player");
        }
    }

    //states
    void idel()
    {
        animator.Play("idel");
        isCharging = false;
        Invoke("charge_attack", 5);
    }

    void charge_attack()
    {
        animator.Play("forward_charge");
        isCharging = true;
        Invoke("back_charge_attack", 2.5f);
    }

    void back_charge_attack()
    {
        animator.Play("backcharge");
        Invoke("idel", 2f);
    }
}
