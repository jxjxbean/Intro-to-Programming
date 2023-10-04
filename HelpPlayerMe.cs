using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPlayerMe : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    float jumpHeight = 3;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1.5f * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.E))
        {
            myRigidBody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }
}
