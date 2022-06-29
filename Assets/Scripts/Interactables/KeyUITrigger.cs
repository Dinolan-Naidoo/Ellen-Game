using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUITrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Checks the collision with the key via tag
        if (other.tag == "Key1")
        {
            FindObjectOfType<KeyControl>().UIControl();
            Debug.Log("KeyCollision");
        }

    }
}
