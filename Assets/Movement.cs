using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    public int moveSpeed;
    public int jumpForce;
    public float extra = 0.1f;
    private float movement;
    private Rigidbody2D rb;
    private Vector2 mousePos;
    public GameObject groundPar;
    public Transform playerGround;
    
    
    // Make sure to use a composite collider for tilemaps so it doesn't stop randomly
    //click using composite collider on the actual collider so it recognized the composite collider
    //Also make sure you have a physics material that has no friction so you don't stick to walls
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if(movement != 0 && IsGrounded()) {
            animator.SetBool("isRunning", true);
            Instantiate(groundPar, playerGround.position, playerGround.rotation);
        }
        else {
            animator.SetBool("isRunning", false);
        }
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() && rb.velocity.y < 0.5f && rb.velocity.y > -0.5f)
        {
            animator.SetTrigger("isJumping");
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Debug.Log("Jumping");
        }
        
    }
    bool IsGrounded()
    {
        return Physics2D.Raycast(GetComponent<BoxCollider2D>().bounds.center, Vector2.down, GetComponent<BoxCollider2D>().bounds.extents.y + extra, LayerMask.GetMask("Ground"));
    }
    private void FixedUpdate()
    {

        if(movement != 0)
        {
            rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
