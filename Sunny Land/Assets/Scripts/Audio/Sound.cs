using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [HideInInspector] public AudioSource source;
    public AudioClip clip;
    public string name;
    [Range(0.1f, 1f)] public float volume = 1;
    [Range(0.1f, 3f)] public float pitch = 1;
}