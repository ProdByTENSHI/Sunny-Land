using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public static SceneHandler Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);

        Instance = this;
    }

    public static void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public static void LoadLevel(int level)
    {
        SceneManager.LoadScene(level + 1);      // Level Index + Main Menu
    }

    public static int GetCurrentSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}