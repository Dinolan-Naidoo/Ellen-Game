using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform EllenFollow;
    public float y_axis_offset;
    
    //Follows Ellens position with the y_axis offset which can be adjusted in the inspector
    private void FixedUpdate()
    {
        transform.position = new Vector3(EllenFollow.position.x, EllenFollow.position.y+ y_axis_offset, transform.position.z);
    }
}
