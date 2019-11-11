using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public static Obstacles instance = null;
    [SerializeField]
    private float moveSpeed = -5f;


    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,
            transform.position.y);
        moveSpeed += Time.deltaTime * -0.2f;

        
    }

}
