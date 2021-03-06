using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterShoot1 : MonoBehaviour
{
    public Transform FirePoint;
  
    Animator anim;
    private float TimedShots;
    public float startShooting;
    Object bulletRef;


    private void Start()
    {
        //Gets the animator components and links it to the anim variable
        anim = GetComponent<Animator>();

        //Makes sure that Timed shots ans start shooting are equal to each other at the start of the game
        TimedShots = startShooting;

        //References the bullet prefab in the resources folder
        bulletRef = Resources.Load("SpitterBullet2");
    }

    
    void Update()
    {
        if (TimedShots <= 0)
        {
            //Shoots a bullet once the timer has reached 0
            shoot();

            //Makes sure that timed shots is equal to start shooting at this instant
            TimedShots = startShooting;
            
        }
        else
        {
            //Operates as a decrement timer
            TimedShots -= Time.deltaTime;

            //Sets shooting animation to false
            anim.SetBool("IsShooting", false);
        }
        
    }

    //Instantiates bullets at specific FirePoint & Plays animation at this instant
    void shoot()
    {
        Instantiate(bulletRef, FirePoint.position, FirePoint.rotation);
        anim.Play("SpitterAttack");
        anim.SetBool("IsShooting", true);
    }
}
