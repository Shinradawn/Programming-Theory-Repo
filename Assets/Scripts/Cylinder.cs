using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shapes
{

    private float zRange = 2;
    
    private bool isHeadingUp = true;

    protected override void Move()
    {
        CheckDirection();
        if (isHeadingUp)
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime, Space.World);
        }
    }

    private void CheckDirection()
    {
        if (gameObject.transform.position.z < -zRange)
        {

            isHeadingUp = true;
        }
        if (gameObject.transform.position.z > zRange)
        {

            isHeadingUp = false;
        }
    }
}
