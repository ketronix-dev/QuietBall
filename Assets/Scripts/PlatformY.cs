using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformY : MonoBehaviour
{
    private float dirX;
    public float speedF;
    private bool moveright;
    public float startPos;
    public float donePos;

    private void Update()
    {
        if (transform.position.y > donePos)
        {
            moveright = false;
        }else if (transform.position.y <= startPos)
        {
            moveright = true;
        }

        if (moveright)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speedF * Time.deltaTime,
                transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speedF * Time.deltaTime,
                transform.position.z);
        }
    }
    
}