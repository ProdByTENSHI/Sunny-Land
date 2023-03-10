using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private FileManager fileManager;
    private GameData gameData;

    public static int currentLevel;

    private void Awake()
    {
        // Initialize Filemanager and try to load Gamedata
        fileManager = new FileManager();
        gameData = fileManager.Load("Save_1");

        // Create new Gamedata if no File was found; Load Game Data if File was found;
        if(gameData == null)
        {
            gameData = new GameData();
        } else
        {
            PlayerHealth.currentHealth              = gameData.currentHealth;
            PlayerHealth.maxHealth                  = gameData.maxHealth;
            PlayerManager.points                    = gameData.points;
            CheckPointManager.currentCheckPoint     = gameData.currentCheckPoint;
            currentLevel                            = gameData.currentLevel;
        }

        // Set initial Gamespeed
        SetGameSpeed(1);
    }

    private void Start()
    {

        PlayerHealth.onDeath += OnDeath;
    }

    private void Update()
    {
        // Override Gamedata
        gameData.currentHealth          = PlayerHealth.currentHealth;
        gameData.maxHealth              = PlayerHealth.maxHealth;
        gameData.points                 = PlayerManager.points;
        gameData.currentCheckPoint      = CheckPointManager.currentCheckPoint;
        gameData.currentLevel           = SceneHandler.GetCurrentSceneIndex();
    }

    private void OnDeath()
    {
        // SetGameSpeed(0);
        fileManager.Save("Save_1", gameData);       // Save Gamedata on Death
    }

    // Set Timescale
    public static void SetGameSpeed(int time)
    {
        Time.timeScale = time;
    }
}