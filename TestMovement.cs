using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I set isitColliding to false.
        isitColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isitColliding == false)
        {
            //my game oject will move 2 units to the righton the z axis)
            transform.position += new Vector3(0, 0, 2 * Time.deltaTime);

        }

        if(isitColliding == true)
        {
            //my game object will move 2 units to the left on the z axis
            transform.position += new Vector3(0, 0, -2 * Time.delaTime);

        }
    //'other' can be called anything as long as you keep track of it
    }id OnCollisionEnter(Collision other)
    {
        //if my game object has a tag names WallNorth and my boolean variable is false than isitCollising because
        isitColliding = true

        transform.position += new Vector(0, 0, 0);
    }
}
