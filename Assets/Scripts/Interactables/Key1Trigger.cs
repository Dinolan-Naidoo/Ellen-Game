using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key1Trigger : MonoBehaviour
{
    [SerializeField] public Image key1Image ;
    [SerializeField] public AudioSource keySound ;
    public GameObject deathEffect;

    private void Start()
    {
        key1Image.enabled = false;
    }

    //Checks whether Ellen has collected the key and enables the UI image
    //Checks whether Ellen has used the key to open a door and disables the UI image
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ellen"))
        {
            key1Image.enabled = true;
            keySound.Play();
            
        }

        if (collision.CompareTag("Door1"))
        {
            key1Image.enabled = false;
        }
    }

    //Checks whether Ellen has left the trigger and disables the initial trigger.
    private void OnTriggerExit2D(Collider2D collision)
    {
        this.enabled = false;
    }

}
