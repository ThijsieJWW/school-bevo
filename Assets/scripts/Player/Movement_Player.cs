using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.scripts.CharacterMenu;

public class Movement_Player : MonoBehaviour
{
    public float Move_Speed;
    public Rigidbody2D rb;

    public float JumpForce = 20f;
    public Transform GroundCheck;
    public LayerMask groundLayers;
    public float killForce = 25f;

    //slide vairibles
    public bool sliding = false;
    public float slide_speed;
    public BoxCollider2D BC2D;

    //varibles for animation
    public Animator animtor;

    //variable for lvl 5
    public bool can_move_right = true;

    float mx;

    private void Start()
    {
        animtor.SetInteger("player", CharacterSettings.SelectedCharacter);
    }

    private void Update()
    {
        if (can_move_right = true &&Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)//check if nothing is pressed
        {
            mx = 0f; // set the forces to nothing
            animtor.SetFloat("speed", 0);
        }

        if (Input.GetKey(KeyCode.D))//check for the D button
        {
            mx = 1f;//set the forces to right
            animtor.SetFloat("speed", 1);
        }

        if (Input.GetKey(KeyCode.A))//check for the A button
        {
            mx = - 1f;//set the forces to left
            animtor.SetFloat("speed", 1);
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrouned())
        {
            animtor.SetFloat("speed", 0);
            Jump();
        }

        if (Input.GetKey(KeyCode.S))
        {
            sliding = true;
        }
        else
        {
            sliding = false;
        }

        Slide();
        DamageEnemy();
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * Move_Speed, rb.velocity.y);//rekent de movemt snelheid en de directie

        rb.velocity = movement;//voert de forces uit
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, JumpForce);
        rb.velocity = movement;
    }

    public bool isGrouned()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(GroundCheck.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }

    public LayerMask enemyLayers;
    public float DistanceEnemy = 1.25f;

    void DamageEnemy()
    {
        RaycastHit2D EnemyCheck;
        if (EnemyCheck = Physics2D.Raycast(transform.position, -transform.up, DistanceEnemy, enemyLayers))
        {
            DamagePlayer health = EnemyCheck.transform.GetComponent<DamagePlayer>();
            Vector2 movement = new Vector2(rb.velocity.x, JumpForce);
            rb.velocity = movement;
            if (health != null)
            {
                health.die();
            }
        }

    }

    void Slide()
    {
        if (sliding == true)
        {
            if (mx < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, -90);
                //BC2D.size = new Vector2(0.5f, 1f);
                //BC2D.offset = new Vector2(-0.1f, -0.2f);
            }

            if (mx > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
                //BC2D.offset = new Vector2(-0.1f, -0.1f);
            }
            
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //BC2D.size = new Vector2(0.5f, 1.2f);
            //BC2D.offset = new Vector2(-0.1f, -0.2f);
        }
    }
}
