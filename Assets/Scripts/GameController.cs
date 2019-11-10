using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float spawnTime = 2f;
    public float spawnObstacle;
    public float xSpread;
    public GameObject[] obstacle;
    public Transform spawnPosition;

   void Start()
    {
        spawnTime = Random.Range(1, 5);
    }

    void Update()
    {
        if(Time.time > spawnObstacle)
            SpawnObstacle();    
    }

    public void SpawnObstacle()
    {
        spawnObstacle = Time.time + Random.Range(1, 5);
        int randomObstacle = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[randomObstacle], spawnPosition.position, Quaternion.identity);
    }
}
