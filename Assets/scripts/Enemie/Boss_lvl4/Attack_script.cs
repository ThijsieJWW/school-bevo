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
    public Animator walk_animator;
    public SpriteRenderer body_render;

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
        body_render.flipX = true;
        animator.Play("idel");
        walk_animator.Play("idel");
        isCharging = false;
        Invoke("charge_attack", 5);
    }

    void charge_attack()
    {
        animator.Play("charge");
        walk_animator.Play("running");
        isCharging = true;
        Invoke("back_charge_attack", 2.5f);
    }

    void back_charge_attack()
    {
        body_render.flipX = false;
        animator.Play("back_charge");
        walk_animator.Play("running");
        Invoke("idel", 2f);
    }
}
