using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
    float moveX;
    float moveY;
    public float movementSpeed;
    public float rotateSpeed;
    Rigidbody2D myRigidbody;
    float jumpHeight

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5;
        rotateSpeed = 1;
        myRigidbody = GetComponent<Rigidbody2D>();
        jumpHeight = 3;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        transform.Translate(moveX * Time.deltaTime * movementSpeed, 0, 0);
        transform.Translate(0, moveY * Time.deltaTime * movementSpeed, 0);

        if (Input.GetKeyDown(KeyCode.E))
        {
            myRigidbody.AddForce(vector2.up*jumpHeight, ForceMode.impulse);
        }

    }
}
