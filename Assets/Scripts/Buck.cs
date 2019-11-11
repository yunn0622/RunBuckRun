using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buck : MonoBehaviour
{
    public float jumpForce = 2f;
    public Transform onGround;
    public float buckRadius;
    public LayerMask groundLayer;
    private bool isNotJumping;


    Rigidbody2D buckRigidBody;

    void Start()
    {
        buckRigidBody = GetComponent<Rigidbody2D>();
        //buckRigidBody.simulated = false;
    }

    void Update()
    {
        isNotJumping = Physics2D.OverlapCircle(onGround.position, buckRadius, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isNotJumping)
        {
            //buckRigidBody.AddForce(Vector2.up * jumpForce);
            buckRigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            //die
            buckRigidBody.simulated = false;
            Debug.Log("game over");
            GameController.instance.BuckDead();
            //register a dead event
            //play sound
        }

        if (collision.gameObject.tag == "score")
        {
            Debug.Log("score");
            GameController.instance.Score();
        }



    }
}