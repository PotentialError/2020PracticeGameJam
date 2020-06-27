using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            animator.SetBool("isRunning", true);
        }
        else {
            animator.SetBool("isRunning", false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("isJumping");
        }
    }
}
