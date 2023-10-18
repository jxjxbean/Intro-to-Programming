using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float xValue;
    float yValue;
    float zValue;
    float playerSpeed;
    float jumpHeight;
    Rigidbody playerRB;
    // giving names to the xyz variables and 


    void Start()
    {

        playerSpeed = 5.25f;

        yValue = 0;

        PrepareToJump();

    }



    void Update()
    {

        MoveMe();

        MakeMeJump();



    }



    void MoveMe()
    {

        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;

        zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

        transform.Translate(xValue, yValue, zValue);

    }



    void PrepareToJump()
    {

        playerRB = GetComponent<Rigidbody>();

        jumpHeight = 10f;

    }



    void MakeMeJump()
    {

        playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);

    }


