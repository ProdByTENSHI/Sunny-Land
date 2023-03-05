using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    // Player Data
    public int points;
    public int currentHealth;
    public int maxHealth;

    // Level
    public int currentLevel;
    public int currentCheckPoint;
    
    // Items
    public Dictionary<string, PointItem> pointItems;
}