using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void Start()
    {
        // TODO: Change to Saving the Last Checkpoint
        PlayerManager.onDeath += Save;      // Save when Dying
    }

    public static void Save()
    {
        PlayerPrefs.SetInt("Points", PlayerManager.points);
        PlayerPrefs.SetInt("Health", PlayerManager.health);

        Debug.Log($"{PlayerPrefs.GetInt("Points")}");
    }

    public static void Load()
    {
        PlayerManager.health = PlayerPrefs.GetInt("Health");
        PlayerManager.points = PlayerPrefs.GetInt("Points");

        Debug.Log($"Loaded {PlayerPrefs.GetInt("Points")}");
    }
}