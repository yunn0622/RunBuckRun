using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    public static MoveClouds instance = null;

    [SerializeField]
    private float moveSpeed = -1f;

    [SerializeField]
    private float leftWayPointX = -8f;
    [SerializeField]
    private float rightWayPointX = 8f;


    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,
            transform.position.y);

        if (transform.position.x < leftWayPointX)
            transform.position = new Vector2(rightWayPointX, transform.position.y);

        if (transform.position.x < -7.5f)
            Destroy(gameObject);
        moveSpeed += Time.deltaTime * -0.2f;
    }

}
