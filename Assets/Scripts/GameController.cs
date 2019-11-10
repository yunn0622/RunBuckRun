using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public float spawnTime = 2f;
    public float spawnObstacle;
    public float xSpread;
    public GameObject[] obstacle;
    public GameObject cloud;
    public Transform spawnPosition;
    private float yPos;
    public float cloudSpawnTime;
    private int score = 0;
    private bool gameStopped = false;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        spawnTime = Random.Range(1, 5);
    }

    void Update()
    {
        if (Time.time > spawnObstacle)
            SpawnObstacle();
        if (Time.time > cloudSpawnTime)
            SpawnCloud();
    }

    public void SpawnObstacle()
    {
        spawnObstacle = Time.time + Random.Range(1, 5);
        int randomObstacle = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[randomObstacle], spawnPosition.position, Quaternion.identity);
    }

    public void SpawnCloud()
    {
        cloudSpawnTime = Time.time + Random.Range(1.0f, 2.0f);
        yPos = Random.Range(2, 4);
        Instantiate(cloud, new Vector2(8.22f, yPos), Quaternion.identity);
    }

    public void BuckDead ()
    {
        Time.timeScale = 0;
        gameStopped = true;

    }
}
