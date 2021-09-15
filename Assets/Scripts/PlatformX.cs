using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformX : MonoBehaviour
{
    private float dirX;
    public float speedF;
    private bool moveright;
    public float startPos;
    public float donePos;

    private void Update()
    {
        if (transform.position.x > donePos)
        {
            moveright = false;
        }else if (transform.position.x <= startPos)
        {
            moveright = true;
        }

        if (moveright)
        {
            transform.position = new Vector3(transform.position.x + speedF * Time.deltaTime, transform.position.y,
                transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speedF * Time.deltaTime, transform.position.y,
                transform.position.z);
        }
    }
    
}