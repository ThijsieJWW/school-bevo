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
    //slider refrence
    public Slider hpslider;
    //refrences to animations isendoorn
    public Animator isen_animator;

    // Start is called before the first frame update

    private void Awake()
    {
        //setting up health
        current_hp = Max_hp;
        //setting up healt slider
        hpslider.value = Max_hp;
        hpslider.maxValue = Max_hp;
        
    }

    void Start()
    {
        //trow object rigidbody
        trow_object_rigidboy = trow_object.GetComponent<Rigidbody2D>();
        Invoke("Attack1", 2);
        //set the math problem panel to nonactive (pure to avoid bugs)
        math_problem_panel.SetActive(false);
    }

    private void Update()
    {
        hpslider.value = current_hp;
    }

    void Attack1()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack2", 1);
    }
    void Attack2()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack3", 1);
    }
    void Attack3()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack4", 1);
    }
    void Attack4()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack5", 1);
    }

    void Attack5()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack6", 1);
    }
    void Attack6()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack7", 1);
    }
    void Attack7()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack8", 1);
    }
    void Attack8()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack9", 1);
    }

    void Attack9()
    {
        //plays animation
        isen_animator.Play("trow_attack");
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("Attack10", 1);
    }
    void Attack10()
    {
        Instantiate(trow_object, attack_point.position, attack_point.rotation);
        Invoke("start_math_problem", 3);
        isen_animator.Play("idel");
        //plays animation
        isen_animator.Play("trow_attack");
    }

    void start_math_problem()
    {
        math_problem_panel.SetActive(true);
        math_code.calculte_diff_num();
        Invoke("end_math_problem", 7.5f);
    }

    void end_math_problem()
    {
        math_problem_panel.SetActive(false);
        Start();
    }

    //take damage
    //health stats
    public int Max_hp = 100;
    public int current_hp;

    public void TakeDamage(int damage)
    {
        current_hp -= damage;

        if (current_hp <= 0)
        {
            Die();
            math_problem_panel.SetActive(false);
            gamemanger.onFinish();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
