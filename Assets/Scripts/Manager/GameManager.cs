using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public enum GameStateEnum
{
    MainMenu,
    LevelStarting,
    LevelRunning,
    LevelPaused,
    LevelAccomplished,
    LevelLost,
    GameWon,
    GameLost,
}

public class LifePointsChangedEvent : UnityEvent<int> { };
public class CollectableChangedEvent : UnityEvent<int> { };

public class GameManager : MonoBehaviour
{
    // Game Adjustment
    [SerializeField]
    // private static int initLifePoints = 5;

    // Game Stateparam
    private static GameManager _instance;
    private int _roundsPlayed = 0;
    private int _lifeCounter = 5;
    private float _time = 0;
    private int _points = 0;

    // Public Getter  
    public static GameManager Instance { get { return _instance; } }
    public GameStateEnum GameState { get; private set; }
    public int roundsPlayed { get { return _roundsPlayed; } }
    public int lifeCounter { get { return _lifeCounter; } }
    public float TimeCounter { get { return _time; } set { _time = value; } }
    public int pointsCounter { get { return _points; } set { _points = value; } }

    // Events
    public LifePointsChangedEvent lifeCounterChanged = new LifePointsChangedEvent();
    public CollectableChangedEvent CollectableChanged = new CollectableChangedEvent();
    public UnityEvent gameStateChanged = new UnityEvent();

    // Automated Preloading of GameManager
    public static void Load()
    {
        if (_instance == null)
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(0);
            SceneManager.LoadScene(nextScene);
        }
    }

    // Instantiate GameManger - Singelton
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        StartMainMenu();
    }

    // Manage Gamestate
    public void LevelLost()
    {
        _lifeCounter--;
        SpawnerController.stopSpawn = false;
        CollectableChanged.Invoke(pointsCounter);
        lifeCounterChanged.Invoke(lifeCounter);


        if (_lifeCounter > 0)
        {
            Debug.Log("GameManager-LevelLost - You have fallen out the World");
            _roundsPlayed++;
            GameState = GameStateEnum.LevelLost;

            // Event Triggers HUD Controller            
        }
        else
        {
            Debug.Log("GameManager-GameLost - You have fallen out the World");
            GameState = GameStateEnum.GameLost;
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);    // Loads next Scene
        }
        Time.timeScale = 0;
        // _points = 0;
        gameStateChanged.Invoke();
    }

    public void LevelWon()
    {
        if (SceneManager.sceneCountInBuildSettings - 1 < SceneManager.GetActiveScene().buildIndex)
        {
            Debug.Log("GameManager - GameWon - You accomplished all Levels");
            GameState = GameStateEnum.GameWon;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   // Loads next Scene
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("GameManager - LevelWon - One further step torward greatness");
            GameState = GameStateEnum.LevelAccomplished;
            // Event Triggers HUD Controller
            Time.timeScale = 0;
        }
        gameStateChanged.Invoke();
    }

    // Manage Pause and Continue
    public void PauseLevel()
    {
        Debug.Log("GameManager - Pause -  You Paused the Game");
        GameState = GameStateEnum.LevelPaused;
        Time.timeScale = 0;
        gameStateChanged.Invoke();
    }

    public void ContinueLevel()
    {
        Debug.Log("GameManager - Continue -  Take the reins back and fullfill your burden");
        GameState = GameStateEnum.LevelRunning;
        Time.timeScale = 1;
        gameStateChanged.Invoke();
    }


    // Manage Screens - Managen Button Events in abhängigkeit von GameState
    public void StartLevel()
    {
        SceneManager.LoadScene(2);
        // SceneManager.LoadScene(4);
        GameState = GameStateEnum.LevelRunning;
        _lifeCounter = 5;
        _roundsPlayed = 0;
        _time = 0;
        _points = 0;
        Time.timeScale = 1;
        gameStateChanged.Invoke();
        Debug.Log("GameManager - startLevel Again - ..." + GameState);
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        switch (GameState)
        {
            case (GameStateEnum.LevelAccomplished):
                Debug.Log("GameManager - nextLevel Accomplished - Well Done!");
                GameState = GameStateEnum.LevelRunning;
                gameStateChanged.Invoke();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case (GameStateEnum.LevelLost):
                Debug.Log("GameManager - nextLevel Lost - Well ...");
                GameState = GameStateEnum.LevelRunning;
                gameStateChanged.Invoke();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
        }
    }
    public void StartMainMenu()
    {
        SceneManager.LoadScene(1);
        GameState = GameStateEnum.MainMenu;
        gameStateChanged.Invoke();
    }

    public void SaveCurrentStats()
    {
        //TODO
    }

    public void RaiseCollectable()
    {
        pointsCounter++;
        CollectableChanged.Invoke(pointsCounter);
    }
}
