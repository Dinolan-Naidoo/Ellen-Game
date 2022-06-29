using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject portal;
    public GameObject ellen;
    public AudioSource Teleportsound;

    //Checks whether Ellen has collided with the trigger and starts the teleportation coroutine
    void OnTriggerEnter2D(Collider2D teleport)
    {
       if (teleport.gameObject.tag == "Ellen")
       {
                StartCoroutine(Teleportation());
                Teleportsound.Play();
       }
    }


    //Transforms Ellen's position to the next portal after 1 second has passed
    IEnumerator Teleportation()
    {
        yield return new WaitForSeconds(1);
        ellen.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
    }
}
