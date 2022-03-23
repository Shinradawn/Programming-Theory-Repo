using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shapes
{
    
    private float yRange = 0.6f;
    private float yTop = 4.0f;
    private bool isHeadingUp = true;

    protected override void Move()
    {
        CheckDirection();
        if (isHeadingUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }
    }

    private void CheckDirection()
    {
        if (gameObject.transform.position.y < yRange)
        {
            
            isHeadingUp = true;
        }
        if (gameObject.transform.position.y > yTop)
        {
            
            isHeadingUp = false;
        }
    }
}
