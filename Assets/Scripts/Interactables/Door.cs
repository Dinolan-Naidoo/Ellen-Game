using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Key.KeyType keytype;
    public AudioSource DoorSound;
    public GameObject openEffect;

    //Checks the key type 
    public Key.KeyType GetKeyType()
    {
        return keytype;
    }

    //Opens the door
    public void Opendoor()
    {
        gameObject.SetActive(false);
        DoorSound.Play();
        Instantiate(openEffect, transform.position, Quaternion.identity);
    }
}
