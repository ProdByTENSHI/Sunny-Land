using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int currentLevel;
    private FileManager fileManager;
    private GameData gameData;

    private void Awake()
    {
        fileManager = new FileManager();
        gameData = fileManager.Load("Save_1");
        if(gameData == null)
        {
            gameData = new GameData();
        } else
        {
            PlayerHealth.currentHealth      = gameData.currentHealth;
            PlayerHealth.maxHealth          = gameData.maxHealth;
            PlayerManager.points            = gameData.points;
        }

        SetGameSpeed(1);
    }

    private void Start()
    {

        PlayerHealth.onDeath += OnDeath;
    }

    private void Update()
    {
        currentLevel = SceneHandler.GetCurrentSceneIndex();

        gameData.currentHealth  = PlayerHealth.currentHealth;
        gameData.maxHealth      = PlayerHealth.maxHealth;
        gameData.points         = PlayerManager.points;
    }

    private void OnDeath()
    {
        // SetGameSpeed(0);
        fileManager.Save("Save_1", gameData);
    }

    public static void SetGameSpeed(int time)
    {
        Time.timeScale = time;
    }
}