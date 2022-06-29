using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenMove : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float speed;
    private float moveInput;
    private bool onGround;
    public Transform feetPosition;
    public float checkRadius;
    public LayerMask groundCheck;
    public float jumpForce;
    private Animator anim;

    private void Start()
    {
        //References the animator
        anim = GetComponent<Animator>();

        //References Ellen's rigidbody 
        Rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Gives Ellen a horizontal velocity
        moveInput = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(moveInput * speed, Rb.velocity.y);  
    }

    private void Update()
    {
        //Checks whether Ellen is on the grounf before allowing her to jump
        onGround = Physics2D.OverlapCircle(feetPosition.position, checkRadius, groundCheck);
        
        if (onGround == true  && Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("Ellen_Jump");
            Rb.velocity = Vector2.up * jumpForce;
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }

        //Checks whether Ellen is stationary
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        //Checks whether the move input is positive and sets her posision to moving right
        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //Checks whether the move input is negative and sets her posision to moving left
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }

    //Transforms Ellen's position on the moving platforms
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==("MovingPlatform"))
        {
            this.transform.parent = collision.transform;
        } 
    }

    //Stops transforming Ellen's position when she jumps off the moving platform
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("MovingPlatform"))
        {
            this.transform.parent = null;
        }
    }

}
