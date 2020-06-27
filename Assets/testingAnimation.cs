﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingAnimation : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f"))
        {
            ani.SetBool("fKeyPressed", true);
        }
        else
        {
            ani.SetBool("fKeyPressed", false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            ani.SetTrigger("spacePressed");
        }
    }
}
