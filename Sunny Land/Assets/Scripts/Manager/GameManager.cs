using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        SetGameSpeed(1);
        DataHandler.Load();
    }

    private void Start()
    {
        PlayerManager.onDeath += OnDeath;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            DataHandler.Load();
        } else if(Input.GetKeyDown(KeyCode.S))
        {
            DataHandler.Save();
        }
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