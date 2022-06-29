using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed = 20f;
    public Rigidbody2D RB;
    public int Damage = 40;
    public GameObject impactEffect;

    void Start()
    {
        //Transforms the bullet to the right
        RB.velocity = transform.right.normalized* Speed;
    }

    //If it collides with an enemy the enemy will lose health, the impact effect is activated and the bullet is destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //If the bullet collides with any other object , the impact effect is activated and the bullet is destroyed
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
