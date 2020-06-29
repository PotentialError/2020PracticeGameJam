using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    public int moveSpeed;
    public int jumpForce;
    public float extra = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        if(movement != 0 && IsGrounded()) {
            animator.SetBool("isRunning", true);
        }
        else {
            animator.SetBool("isRunning", false);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            animator.SetTrigger("isJumping");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (movement < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(movement > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    bool IsGrounded()
    {
        return Physics2D.Raycast(GetComponent<BoxCollider2D>().bounds.center, Vector2.down, GetComponent<BoxCollider2D>().bounds.extents.y + extra, LayerMask.GetMask("Ground"));
    }
}
