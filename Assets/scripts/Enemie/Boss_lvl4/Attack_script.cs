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
        animator.Play("charge");
        isCharging = true;
        Invoke("back_charge_attack", 2.5f);
    }

    void back_charge_attack()
    {
        animator.Play("back_charge");
        Invoke("basketbal_attack_for", 4f);
    }

    void basketbal_attack_for()
    {
        animator.Play("idel");
        for (int i = 0; i <= 10; i++)
        {
            Invoke("basketbal_attack", 1f);
            if (i == 10)
            {
                Invoke("idel", 1f);
            }
        }
    }

    void basketbal_attack()
    {
        Instantiate(basketbal, point_to_shoot.position, transform.rotation);
    }
}
