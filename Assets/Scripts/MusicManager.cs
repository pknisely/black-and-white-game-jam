using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
   
    // Audio Source object for SFX
    public AudioSource sfxAudio;

    // Audio Source objects for the seven music tracks
    [SerializeField] private AudioSource track1Audio;
    [SerializeField] private AudioSource track2Audio;
    [SerializeField] private AudioSource track3Audio;
    [SerializeField] private AudioSource track4Audio;
    [SerializeField] private AudioSource track5Audio;
    [SerializeField] private AudioSource track6Audio;
    [SerializeField] private AudioSource track7Audio;

    // Variable for the Player to track their position
    public GameObject PlayerObject;
    public PlayerControllerTUTORIAL controller;

    // Creating object of GlobalVars type
    public GlobalVars globalVars;

    // A number for the current music volume
    public float musicVolumeSetting;

    // A number for the current music volume
    public float sfxVolumeSetting;

    // Slider objects
    public Slider sfxVolumeSlider;
    public Slider musicVolumeSlider;

    // Flags for whether or not tracks 2 through 7 are playing
    public bool track2Playing = false;
    public bool track3Playing = false;
    public bool track4Playing = false;
    public bool track5Playing = false;
    public bool track6Playing = false;
    public bool track7Playing = false;

    // We'll want one default audio source to start playing on start
    void Start()
    {

        // Get the current settings for music and sfx volume from the GlobalVars variables
        musicVolumeSetting = PlayerPrefs.GetFloat("musicVolume", 1);
        sfxVolumeSetting = PlayerPrefs.GetFloat("sfxVolume", 1);

        // Set the sliders values to the current settings;
        musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume", 1);
        sfxVolumeSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1);

        sfxAudio.volume = sfxVolumeSetting;
        track1Audio.volume = musicVolumeSetting;
        track2Audio.volume = 0;
        track3Audio.volume = 0;
        track4Audio.volume = 0;
        track5Audio.volume = 0;
        track6Audio.volume = 0;
        track7Audio.volume = 0;

        // Listen for changes to the volume
        sfxVolumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
        musicVolumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2) || SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(3))
            UpdateTracks(PlayerObject.transform.position.y);
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            if (controller.noHeadphones == false)
            {
                track1Audio.volume = musicVolumeSetting;
            }
            UpdateTracksTutorial(PlayerObject.transform.position.y);
        }
        else
            return;
    }

    // Function to update the music based on the player's y position for the 1st level or tutorial level

    void UpdateTracksTutorial(float yPos)
    {
        StopAllCoroutines();

        // Handles track 4
        if (yPos > -60)
        {
            StartCoroutine(FadeAudioSource(track4Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -60)
        {
            StartCoroutine(FadeAudioSource(track4Audio, 1f, 0));
        }

        // Handles track 3
        if (yPos > -68.666)
        {
            StartCoroutine(FadeAudioSource(track3Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -68.666)
        {
            StartCoroutine(FadeAudioSource(track3Audio, 1f, 0));
        }

        // Handles track 2
        if (yPos > -77.333)
        {
            StartCoroutine(FadeAudioSource(track2Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -77.333)
        {
            StartCoroutine(FadeAudioSource(track2Audio, 1f, 0));
        }
    }


    // Function to update the music based on the player's y position for levels 2 and 3
    void UpdateTracks(float yPos)
    {
        StopAllCoroutines();
        // Handles track 7
        if (yPos > 0)
        {
            track7Playing = true;
            StartCoroutine(FadeAudioSource(track7Audio, 5, musicVolumeSetting));
        }
        if (yPos <= 0)
        {
            track7Playing = false;
            StartCoroutine(FadeAudioSource(track7Audio, 1f, 0));
        }

        // Handles track 6
        if (yPos > -15)
        {
            track6Playing = true;
            StartCoroutine(FadeAudioSource(track6Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -15)
        {
            track6Playing = false;
            StartCoroutine(FadeAudioSource(track6Audio, 1f, 0));
        }

        // Handles track 5
        if (yPos > -30)
        {
            track5Playing = true;
            StartCoroutine(FadeAudioSource(track5Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -30)
        {
            track5Playing = false;
            StartCoroutine(FadeAudioSource(track5Audio, 1f, 0));
        }

        // Handles track 4
        if (yPos > -45)
        {
            track4Playing = true;
            StartCoroutine(FadeAudioSource(track4Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -45)
        {
            track4Playing = false;
            StartCoroutine(FadeAudioSource(track4Audio, 1f, 0));
        }

        // Handles track 3
        if (yPos > -60)
        {
            track3Playing = true;
            StartCoroutine(FadeAudioSource(track3Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -60)
        {
            track3Playing = false;
            StartCoroutine(FadeAudioSource(track3Audio, 1f, 0));
        }

        // Handles track 2
        if (yPos > -72.5)
        {
            track2Playing = true;
            StartCoroutine(FadeAudioSource(track2Audio, 5, musicVolumeSetting));
        }
        if (yPos <= -72.5)
        {
            track2Playing = false;
            StartCoroutine(FadeAudioSource(track2Audio, 1f, 0));
        }
    }

    private IEnumerator FadeAudioSource(AudioSource trackAudio, float duration, float targetVolume)
    {

        float currentTime = 0;
        float start = trackAudio.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            trackAudio.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
    public void ChangeVolume()
    {
        sfxVolumeSetting = sfxVolumeSlider.value;
        musicVolumeSetting = musicVolumeSlider.value;
        sfxAudio.volume = sfxVolumeSetting;
        track1Audio.volume = musicVolumeSetting;
        globalVars.currentSFXVolume = sfxVolumeSetting;
        globalVars.currentMusicVolume = musicVolumeSetting;

        if (track2Playing == true)
            track2Audio.volume = musicVolumeSetting;
        if (track3Playing == true)
            track3Audio.volume = musicVolumeSetting;
        if (track4Playing == true)
            track4Audio.volume = musicVolumeSetting;
        if (track5Playing == true)
            track5Audio.volume = musicVolumeSetting;
        if (track6Playing == true)
            track6Audio.volume = musicVolumeSetting;
        if (track7Playing == true)
            track7Audio.volume = musicVolumeSetting;
    }

}
