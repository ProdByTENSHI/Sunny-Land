using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void Start()
    {
        // TODO: Change to Saving the Last Checkpoint
        PlayerHealth.onDeath += () => PlayerPrefs.DeleteKey("Points");      // Clear Points when Dying
    }

    public static void Save()
    {
        PlayerPrefs.SetInt("Points", PlayerManager.points);
        PlayerPrefs.SetInt("Health", PlayerHealth.currentHealth);

        PlayerPrefs.SetInt("Current_Level", GameManager.currentLevel);

        Debug.Log($"{PlayerPrefs.GetInt("Points")}");
    }

    public static void Load()
    {
        PlayerHealth.currentHealth = PlayerPrefs.GetInt("Health");
        PlayerManager.points = PlayerPrefs.GetInt("Points");

        GameManager.currentLevel = PlayerPrefs.GetInt("Current_Level");

        Debug.Log($"Loaded {PlayerPrefs.GetInt("Points")}");
    }
}