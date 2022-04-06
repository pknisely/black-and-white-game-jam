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
        
    }

    private void Update()
    {
        UpdateTracks(PlayerObject.transform.position.y);
    }

    // Function to play the current audio
    public void PlayAudio(AudioSource radioAudio)
    {
        radioAudio.Play();
    }



    
    // Function to update the music based on the player's y position
    void UpdateTracks(float yPos)
    {
        // Handles track 6
        if (yPos > -50)
        {
            Show(track7Audio);
        }
        if (yPos <= -50)
        {
            Hide(track7Audio);
        }

        // Handles track 6
        if (yPos > -55)
        {
            Show(track6Audio);
        }
        if (yPos <= -55)
        {
            Hide(track6Audio);
        }

        // Handles track 5
        if (yPos > -60)
        {
            Show(track5Audio);
        }
        if (yPos <= -60)
        {
            Hide(track5Audio);
        }

        // Handles track 4
        if (yPos > -65)
        {
            Show(track4Audio);
        }
        if (yPos <= -65)
        {
            Hide(track4Audio);
        }

        // Handles track 3
        if (yPos > -70)
        {
            Show(track3Audio);
        }
        if (yPos <= -70)
        {
            Hide(track3Audio);
        }

        // Handles track 2
        if (yPos > -75)
        {
            Show(track2Audio);
        }
        if (yPos <= -75)
        {
            Hide(track2Audio);
        }
    }

    public void Show(AudioSource trackAudio)
    {
        trackAudio.volume = volumeSetting;
    }

    public void Hide(AudioSource trackAudio)
    {
        trackAudio.volume = 0;
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
