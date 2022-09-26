using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    public Rigidbody2D myRigidbody;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask groundWhere;

    private SpriteRenderer mySpriteRenderer;

    private Animator myAnimator;

    void Start()
    {
        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        myAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
        //using player rigidbody, making x axis speed dependent on horixontal controller movement
        myRigidbody.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), myRigidbody.velocity.y);

        //checking if player object groundCheckPoint overlaps with the LayerMask on a layer (ground)
        //so player can only jump if character is on the ground
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, groundWhere);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpSpeed);
            }
        }

        myAnimator.SetBool("isGrounded", isGrounded);
        myAnimator.SetFloat("moveSpeed", Mathf.Abs(myRigidbody.velocity.x));

        //check if rigidbody velocity is negative (left). If yes, flips spriterenderer direction
        //flips back when rigidbody velocity is positive
        if(myRigidbody.velocity.x < 0)
        {
            mySpriteRenderer.flipX = true;
        } else if(myRigidbody.velocity.x > 0)
        {
            mySpriteRenderer.flipX = false;
        }
    }
}
