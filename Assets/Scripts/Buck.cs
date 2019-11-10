using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buck : MonoBehaviour
{
    Animator animator;
    Rigidbody2D buckRigidBody;
    float jumpForce = 10;

    void Start()
    {
        buckRigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        buckRigidBody.velocity = Vector2.up * jumpForce;
    }

}
