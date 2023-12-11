using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentSix : MonoBehaviour
{
    //creating variables giving names to the different speeds of the object
    float enemyAspeedA;
    float enemyAspeedB;
    Rigidbody enemyRigidbodyA;

    // Start is called before the first frame update
    void Start()
    {
        enemyAspeedA = 5f; //sets the objects speed to 5
        enemyAspeedB = 5f; //sets the objcts speed to 5
        enemyRigidbodyA = GetComponent<Rigidbody>(); //helps manipulate the objects gravity and ability to collide with other objects
    }

    // Update is called once per frame
    void Update()
    {
        //continuously moving the object negative of speedA (-5) times the universal speed on the x axis.
        transform.Translate(-enemyAspeedA * Time.deltaTime, 0, 0);

        //if the position of the object is less then or equal to 1.5 on the x axis then:
        if (transform.position.x <= 1.5f)
        {

            enemyAspeedA = 0; //speedA will be set from 5 to 0
            transform.Translate(0, 0, -enemyAspeedB * Time.deltaTime); //instead of speedA the object will start moving the opposite direction of speedB times the universal speed
            enemyAspeedB = 5f; //speedB will remain set to 5

        }

        //if the position of the object is less then or equal to -7.8 on the z axis then:
        if(transform.position.z <= -7.8)
        {
            enemyAspeedB = 0; //speedB will b set from 5 to 0
            transform.position = new Vector3(12f, 19.25f, 2.5f); //the object will be move from 0x0y0z to 12 on the x axis, 19.25 on the y axis, and 2.5 on the z axis
            enemyAspeedA = 5f; //speedA will remain set to 5
        }
    }
}
