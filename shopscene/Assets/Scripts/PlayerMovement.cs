using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed=2;

    private Animator animator;
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
        dirx = Input.GetAxis("Horizontal");
        diry = Input.GetAxis("Vertical");
     
    }
    private void FixedUpdate()
    {
        rb.velocity=new Vector2(dirx*speed,diry*speed);
    }
    
}

