using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float  moveSpeed =3f;
    bool moveRight = true;
    public float RightPosition, LeftPosition;
    

    private void Update()
    {
        //Moves platform left if it exceeds the right position
        if (transform.position.x > RightPosition)
        {
            moveRight = false;
        }
        //Moves platform right if it exceeds the left position
        if (transform.position.x < LeftPosition)
        {
            moveRight = true;
        }

        //Transforms the platform right
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        //Transforms the platform left
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
