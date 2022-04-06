using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
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

    // A number for the current game volume
    public float volumeSetting = 1;

    //    public Slider volumeSlider = null;

    // We'll want one default audio source to start playing on start
    void Start()
    {
        track1Audio.volume = volumeSetting;
        track2Audio.volume = 0;
        track3Audio.volume = 0;
        track4Audio.volume = 0;
        track5Audio.volume = 0;
        track6Audio.volume = 0;
        track7Audio.volume = 0;
    }

    private void Update()
    {
        UpdateTracks(PlayerObject.transform.position.y);
    }

    
    // Function to update the music based on the player's y position
    void UpdateTracks(float yPos)
    {
        StopAllCoroutines();
        // Handles track 7
        if (yPos > 0)
        {
            StartCoroutine(FadeAudioSource(track7Audio, 5, volumeSetting));
        }
        if (yPos <= 0)
        {

            StartCoroutine(FadeAudioSource(track7Audio, 3.5f, 0));
        }

        // Handles track 6
        if (yPos > -15)
        {
            StartCoroutine(FadeAudioSource(track6Audio, 5, volumeSetting));
        }
        if (yPos <= -15)
        {
            StartCoroutine(FadeAudioSource(track6Audio, 3.5f, 0));
        }

        // Handles track 5
        if (yPos > -30)
        {
            StartCoroutine(FadeAudioSource(track5Audio, 5, volumeSetting));
        }
        if (yPos <= -30)
        {
            StartCoroutine(FadeAudioSource(track5Audio, 3.5f, 0));
        }

        // Handles track 4
        if (yPos > -45)
        {
            StartCoroutine(FadeAudioSource(track4Audio, 5, volumeSetting));
        }
        if (yPos <= -45)
        {
            StartCoroutine(FadeAudioSource(track4Audio, 3.5f, 0));
        }

        // Handles track 3
        if (yPos > -60)
        {
            StartCoroutine(FadeAudioSource(track3Audio, 5, volumeSetting));
        }
        if (yPos <= -60)
        {
            StartCoroutine(FadeAudioSource(track3Audio, 3.5f, 0));
        }

        // Handles track 2
        if (yPos > -72.5)
        {
            StartCoroutine(FadeAudioSource(track2Audio, 5, volumeSetting));
        }
        if (yPos <= -72.5)
        {
            StartCoroutine(FadeAudioSource(track2Audio, 3.5f, 0));
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

    /*
    public void ChangeVolume(int index)
    {
        volumeSetting = volumeSlider.value;
        switch (index)
        {
            case 1:
                station1Audio.volume = volumeSetting;
                break;
            case 2:
                station2Audio.volume = volumeSetting;
                break;
            case 3:
                station3Audio.volume = volumeSetting;
                break;
        }
    }
    */
}
