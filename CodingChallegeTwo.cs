using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingChallegeTwo : MonoBehaviour
{
    //assigning names to variables 
    float horiMovement;
    float verMovement;
    float movementSpeed;
    float jumpMovement;
    float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //the object wont move if you dont set a movement speed
        movementSpeed = 5;
        jumpSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //calling pre-assigned keys from unity's input manager
        horiMovement = Input.GetAxis("Horizontal");
        verMovement = Input.GetAxis("Vertical");
        jumpMovement = Input.GetAxis("Jump");

        //directional movement times the movement or jump speed times Time.deltaTime, making it run slower and smoother across all computers
        transform.Translate(horiMovement * Time.deltaTime * movementSpeed, 0, 0);
        transform.Translate(0, 0, verMovement * Time.deltaTime * movementSpeed);
        transform.Translate(0, jumpMovement * Time.deltaTime * movementSpeed, 0);
    }
}
