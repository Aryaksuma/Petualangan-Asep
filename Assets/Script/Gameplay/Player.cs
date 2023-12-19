using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private bool grounded;

    void Start()
    {
        
    }

    private void Update()
    {
        

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        if (horizontalInput > -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontalInput < 0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
        if (grounded && Input.GetKeyDown(KeyCode.J))
        {
            anim.SetBool("punch", true);
            Invoke("StopPunch", 1f);
        }

        /*if (grounded && Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("shoot", true);
            Invoke("StopShoot", 1f);
        }*/

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }

        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }

    private void StopPunch()
    {
        anim.SetBool("punch", false);
        anim.SetBool("grounded", true);
    }

    /*private void StopShoot()
    {
        anim.SetBool("shoot", false);
        anim.SetBool("grounded", true);
    }*/

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground");
        grounded = true;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AttackEnemy"))
        {
            GetComponent<PlayerHealth>().TakeDamage(10);
            rb.AddForce(Vector2.left * 20, ForceMode2D.Impulse);
        }
    }

    
}
