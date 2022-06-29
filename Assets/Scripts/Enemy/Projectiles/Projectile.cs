using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    public Vector2 target;
    public GameObject impactEffect;
    
    
    private void Start()
    {
        //Checks for the "Player" game object via tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //Sets a target position to the player's position
        target = new Vector2(player.position.x, player.position.y);
        
    }

    private void FixedUpdate()
    {
        //Shoots projectile
        project();

        //Checks the position of the projectile with reference to the target position and destroys it if they are equal
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }

    }


    
    //Checks for a collision with Ellen , instantiates an effect, and then destroys itself.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ellen")
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);
            
            Destroy(gameObject);
        }
    }

    //This adds a force to the projectile in order to move towards the target position
    void project()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}

