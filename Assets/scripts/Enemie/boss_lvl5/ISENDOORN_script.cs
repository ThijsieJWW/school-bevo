using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ISENDOORN_script : MonoBehaviour
{
    //trow object
    public GameObject trow_object;
    public Rigidbody2D trow_object_rigidboy;
    //attackpoint
    public Transform attack_point;
    //math problem UI reffrence
    public GameObject math_problem_panel;
    //script refrence
    public math_problem_code math_code;
    public GameManger gamemanger;
    // Start is called before the first frame update
    void Start()
    {
        //trow object rigidbody
        trow_object_rigidboy = trow_object.GetComponent<Rigidbody2D>();
        Invoke("Attack1", 2);
        //set the math problem panel to nonactive (pure to avoid bugs)
        math_problem_panel.SetActive(false);
        //setting up health
        current_hp = Max_hp;
    }

    void Attack1()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack2", 1);
    }
    void Attack2()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack3", 1);
    }
    void Attack3()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack4", 1);
    }
    void Attack4()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack5", 1);
    }

    void Attack5()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack6", 1);
    }
    void Attack6()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack7", 1);
    }
    void Attack7()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack8", 1);
    }
    void Attack8()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack9", 1);
    }

    void Attack9()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack10", 1);
    }
    void Attack10()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("start_math_problem", 3);
    }

    void start_math_problem()
    {
        math_problem_panel.SetActive(true);
        math_code.calculte_diff_num();
        Invoke("end_math_problem", 5);
    }

    void end_math_problem()
    {
        math_problem_panel.SetActive(false);
        Start();
    }

    //take damage
    //health stats
    public int Max_hp = 150;
    public int current_hp;

    public void TakeDamage(int damage)
    {
        current_hp -= damage;

        if (current_hp <= 0)
        {
            Die();
            gamemanger.Lvl5_finish();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
