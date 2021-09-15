using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformZ : MonoBehaviour
{
    private float dirX;
    public float speedF;
    private bool moveright;
    public float startPos;
    public float donePos;

    private void Update()
    {
        if (transform.position.z > donePos)
        {
            moveright = false;
        }else if (transform.position.z <= startPos)
        {
            moveright = true;
        }

        if (moveright)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                transform.position.z + speedF * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                transform.position.z - speedF * Time.deltaTime);
        }
    }
    
}