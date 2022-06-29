using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EllenHealth : MonoBehaviour
{
    public int Health=6;
    public int NumberOfHearts=6;
    public int damage=1;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject deathEffect;
    public GameObject hurtEffect;
    private Animator anim;
    public AudioSource ellenHurt;
    public AudioSource backgroundMusic;

    private void Start()
    {
        //References the animator
        anim = GetComponent<Animator>();

        //Plays the background music on start
        backgroundMusic.Play();
        
    }
    private void Update()
    {
        EllenHealthControl();
    }

    //Controls Ellen's Health UI by incrementing or decrementing the values accordingly
    public void EllenHealthControl()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (Health > NumberOfHearts)
            {
                Health = NumberOfHearts;
            }
            if (i < Health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < NumberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    //Decrements Ellen's health integer by 1 every time it is called
    //Plays Ellen's dead landing animation
    //Instantiates a hurt effect
    //Plays the hurt audio
    public void TakeDamage()
    {
        Health -= 1;
        anim.Play("Ellen_DeadLanding");
        Instantiate(hurtEffect, transform.position, Quaternion.identity);
        ellenHurt.Play();

        if (Health <= 0)
        {
            //Loads Game over scene
            SceneManager.LoadScene("GameOver");
        }
        
    }

    //Checks for trap collisions or enemy projectile collisions and decreses Ellen's health
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Trap")|| collision.gameObject.tag == ("Projectile"))
        {
            TakeDamage();
        }
    }
    
}
