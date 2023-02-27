using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        SetGameSpeed(1);
    }

    private void Start()
    {
        PlayerManager.onDeath.AddListener(OnDeath);
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