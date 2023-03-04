using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    public void Save(string filename, GameData data)
    {
        string path = Application.persistentDataPath + "/" + filename + ".json";
        string content = JsonUtility.ToJson(data);

        File.WriteAllText(path, content);

        Debug.Log("Saved at: " + path);
    }

    public GameData Load(string filename)
    {
        string path = Application.persistentDataPath + "/" + filename + ".json";
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(content);
            Debug.Log("Loaded Data");
            return data;
        } else
        {
            Debug.Log("No Savefile found");
            return null;
        }
    }
}