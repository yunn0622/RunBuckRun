using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public float spawnTime = 2f;
    public float spawnObstacle;
    public float xSpread;
    public GameObject[] obstacle;
    public GameObject cloud, money;
    public GameObject Panel_GameOver;
    public Transform spawnPosition;
    public Text scoreText, totalScore;
    private float yPos;
    public float cloudSpawnTime;
    private int score = 0;

    public AudioSource scoreAudio;
    public AudioSource gameoverAudio;

    public void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        Time.timeScale = 1;
        Panel_GameOver.gameObject.SetActive(false);
        scoreText.text = score.ToString() + "  Bucks";
        spawnTime = Random.Range(1, 5);
    }

    void Update()
    {
        if (Time.time > spawnObstacle)
            SpawnObjects();
        if (Time.time > cloudSpawnTime)
            SpawnCloud();
    }

    public void SpawnObjects()
    {
        spawnObstacle = Time.time + Random.Range(1.0f, 4.0f);
        int randomObstacle = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[randomObstacle], spawnPosition.position, Quaternion.identity);
    }

    public void SpawnCloud()
    {
        cloudSpawnTime = Time.time + Random.Range(3.0f, 4.0f);
        yPos = Random.Range(2.0f, 4.0f);
        Instantiate(cloud, new Vector2(8.22f, yPos), Quaternion.identity);
    }

    public void BuckDead ()
    {
        Time.timeScale = 0;
        LoadGameOverPanel();
        gameoverAudio.Play();
    }

    public void Score ()
    {
        score = score + 1;
        scoreText.text = score.ToString() + "  Bucks";
        totalScore.text = score.ToString() + "  Bucks";
        scoreAudio.Play();
    }

    public void LoadGameOverPanel()
    {
        Panel_GameOver.gameObject.SetActive(true);
    }

    public void LoadMenuSecne()
    {  
        SceneManager.LoadScene(0);
    }

    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = (false);
#else
            Application.Quit();
#endif
    }
}
