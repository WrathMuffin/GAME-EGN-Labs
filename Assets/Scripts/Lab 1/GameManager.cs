using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // readable for evryone (get) but settable is private (private set)
    public static GameManager Instance { get; private set; }

    private float currentTime;
    private int totalScore = 0;
    private bool isGameWin = false;
    private bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentTime = 0;

        if (Instance != null && Instance != this)
        {
            // destroy if theres multiple instance of gamemanagers
            Destroy(gameObject);
            return;
        }

        // this object is the Instance now
        Instance = this;

        DontDestroyOnLoad(gameObject); // THE CLASSIC
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        Debug.Log("Time elapsed: " + currentTime.ToString("F2"));
    }

    public void WinGame()
    {
        Debug.Log("Next level! Time completed: " + currentTime.ToString("F2"));

        currentTime = 0;

        int nextScene = (SceneManager.GetActiveScene().buildIndex + 1);

        if (nextScene >= SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }

        SceneManager.LoadScene(nextScene);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        currentTime = 0;
    }
}
