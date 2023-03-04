using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileManager
{
    public void Save(string filename, GameData data)
    {
        string path = Application.persistentDataPath + "/" + filename + ".json";
        string content = JsonUtility.ToJson(data);

        File.WriteAllText(path, content);
    }

    public GameData Load(string filename)
    {
        string path = Application.persistentDataPath + "/" + filename + ".json";
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(content);

            return data;
        } else
        {
            return null;
        }
    }

    public void Delete(string filename)
    {
        string path = Application.persistentDataPath + "/" + filename + ".json";
        if(File.Exists(path))
        {
            File.Delete(path);
        }
    }
}