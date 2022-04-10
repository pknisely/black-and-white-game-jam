using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour
{
    public float currentMusicVolume = 1f;
    public float currentSFXVolume = 1f;
    public float timePlayed = 0;
    public float currentRecord;

    private void Start()
    {
        // Load data from PlayerPrefs -- this might be from previous scene or maybe even
        // previous playthrough
        currentMusicVolume = PlayerPrefs.GetFloat("musicVolume", 1);
        currentSFXVolume = PlayerPrefs.GetFloat("sfxVolume", 1);
        timePlayed = PlayerPrefs.GetFloat("timePlayed", 0);
        currentRecord = PlayerPrefs.GetFloat("currentRecord", 0);
}

    private void OnDestroy()
    {
        Debug.Log("GlobalVars was destoryed");

        // Before we destory this game object, let's save the data to the save file.
        // This will happen whenever object is destroyed, either quitting
        // or changing scenes
        PlayerPrefs.SetFloat("musicVolume", currentMusicVolume);
        PlayerPrefs.SetFloat("sfxVolume", currentSFXVolume);
        PlayerPrefs.SetFloat("timePlayed", timePlayed);
        PlayerPrefs.SetFloat("currentRecord", currentRecord);
    }
}
