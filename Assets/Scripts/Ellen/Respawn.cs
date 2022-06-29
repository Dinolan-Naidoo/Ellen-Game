using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject Section_respawn;
    public GameObject ellen;
    public float Respawn_time;

    //Checks whether Ellen has collided with the trigger and starts the teleportation coroutine
    void OnTriggerEnter2D(Collider2D teleport)
    {
        if (teleport.gameObject.tag == "Ellen")
        {
            StartCoroutine(Teleportation());
        }
    }


    //Transforms Ellen's position to the respawn section after the respawn time has passed
    IEnumerator Teleportation()
    {
        yield return new WaitForSeconds(Respawn_time);
        ellen.transform.position = new Vector2(Section_respawn.transform.position.x, Section_respawn.transform.position.y);
    }
}
