using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int currentLevel;

    private void Awake()
    {
        SetGameSpeed(1);
        DataHandler.Load();
    }

    private void Start()
    {
        PlayerHealth.onDeath += OnDeath;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DataHandler.Load();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            DataHandler.Save();
        }

        currentLevel = SceneHandler.GetCurrentSceneIndex();
    }

    private void OnDeath()
    {
        SetGameSpeed(0);
    }

    public static void SetGameSpeed(int time)
    {
        Time.timeScale = time;
    }
}