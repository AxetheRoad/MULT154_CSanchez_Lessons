using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSorce;
    public const string VOLUME_LEVEL_KEY = "VolumeLevel";
    public const float DEFAULT_VOLUME = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        audioSorce = GetComponent<AudioSource>();

        float volume = PlayerPrefs.GetFloat(VOLUME_LEVEL_KEY, DEFAULT_VOLUME);
        audioSorce.volume = volume;

        DontDestroyOnLoad(gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Adjustvolume(float level)
    {
        audioSorce.volume = level;
        PlayerPrefs.SetFloat("VolumeLevel", level);
    }
}
