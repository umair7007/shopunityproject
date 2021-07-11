using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed=2;
    public Animator animator;
    float dirx;
    float diry;
    public Rigidbody2D rb;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        dirx = Input.GetAxis("Horizontal");// keyboard inputs to dirx (horizontal)
        diry = Input.GetAxis("Vertical");//
        if (dirx == 0 || diry == 0)
        {
            animator.SetInteger("dirx", 0); // integer setting in animator controller
            animator.SetInteger("diry", 0);
        }
        if (dirx>0  && dirx <= 1)
        {
            animator.SetInteger("dirx", 1);
        }
        if (dirx < 0 && dirx <= -1)
        {
            animator.SetInteger("dirx", -1);
        }
        if (diry > 0 && diry <= 1)
        {
            animator.SetInteger("diry", 1);
        }
        if (diry < 0 && diry <= -1)
        {
            animator.SetInteger("diry", -1);
        }
      
    }
    private void FixedUpdate()
    {
        rb.velocity=new Vector2(dirx*speed,diry*speed);// player movement through rigigdbody 
    }
    
}

