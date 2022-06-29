using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;
    public bool movingRight = true;
    public Transform groundDetection;
    private float moveDirection;
    private Rigidbody2D Rb;
    private Animator anim;

    void Start()
    {
        //References the enemy animator
        anim = GetComponent<Animator>();

        //References the enemy rigidbody
        Rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Moves the enemy horizonatlly starting with the right direction
        moveDirection = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(moveDirection * speed, Rb.velocity.y);
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //Checks whether the detection point is detecting the ground via vertical rays pointing downward
        RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        //Checks if there is no ground collision
        if (groundinfo.collider == false)
        {
            if (movingRight == true)
            {
                //Enemy will move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                //Enemy will move right
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
