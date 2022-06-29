using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenShoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    Animator anim;
    

    private void Start()
    {
        //References the animator
        anim = GetComponent<Animator>();  
    }

    void Update()
    {
        //When input key is pressed , Shoot function is called , Bullet is fired in appropriate direction.
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            anim.Play("Ellen_Hurt");
        }
    }

    //Creates bullets and instantiates them at specific FirePoint. 
    void shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
