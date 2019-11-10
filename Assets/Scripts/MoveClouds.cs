using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f;

    [SerializeField]
    float leftWayPointX = -8f;
    float rightWayPointX = 8f;
   
    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,
            transform.position.y);

        if (transform.position.x < leftWayPointX)
            transform.position = new Vector2(rightWayPointX, transform.position.y);
    }
}
