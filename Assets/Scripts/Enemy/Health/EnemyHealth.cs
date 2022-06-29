using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxDamage = 3f;
    public GameObject deathEffect;
    public bool enemyAlive;
    public AudioSource alienDie;

    

    //Checks whether the velocity and magnitude of the collision is greater or less than the maximum damage variable.
    private void OnCollisionEnter2D(Collision2D hitsomething)
    {
        //If the velocity and magnitude of the collision is greater than the maximum damage variable , the object is destroyed.
        if (hitsomething.relativeVelocity.magnitude > maxDamage)
        {
            Die();
        }
    }

    //This function is used in the Ellen Bullet script in order to damage the enemy
    public void TakeDamage(int damage)
    {
        maxDamage -= damage;

        if (maxDamage <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //Creates a death effect at the instant of the object death.
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        enemyAlive = false;
        //Destroys the object.
        Destroy(gameObject);

        //Plays death audio
        alienDie.Play();
    }
}
