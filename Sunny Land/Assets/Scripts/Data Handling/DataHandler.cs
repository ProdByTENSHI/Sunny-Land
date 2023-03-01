using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void Start()
    {
        // TODO: Change to Saving the Last Checkpoint
        PlayerManager.onDeath += Save;      // Reset Player Save when Dying 
    }

    public static void Save()
    {
        int currentPoints = PlayerManager.GetPoints();
        int currentHealth = PlayerManager.GetHealth();

        PlayerPrefs.Save();
        Debug.Log("Saved!");
    }

    public static void Load()
    {
        PlayerManager.SetHealth(PlayerPrefs.GetInt("Player_Health"));
        PlayerManager.AddPoints(PlayerPrefs.GetInt("Player_Points"));

        Debug.Log($"Loaded {PlayerPrefs.GetInt("Player_Points")}");
    }
}