using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    // Array of GameObjects

    public GameObject[] MusicNotes;
    public MusicManager musicManager;

    // Update is called once per frame
    void Update()
    {
        // Check for if you're high enough for each musical note to appear
        if (musicManager.track2Playing == true)
            MusicNotes[0].SetActive(true);
        if (musicManager.track3Playing == true)
            MusicNotes[1].SetActive(true);
        if (musicManager.track4Playing == true)
            MusicNotes[2].SetActive(true);
        if (musicManager.track5Playing == true)
            MusicNotes[3].SetActive(true);
        if (musicManager.track6Playing == true)
            MusicNotes[4].SetActive(true);
        if (musicManager.track7Playing == true)
            MusicNotes[5].SetActive(true);

        // Check for if you're low enough for each musical note to disappear
        if (musicManager.track2Playing == false)
            MusicNotes[0].SetActive(false);
        if (musicManager.track3Playing == false)
            MusicNotes[1].SetActive(false);
        if (musicManager.track4Playing == false)
            MusicNotes[2].SetActive(false);
        if (musicManager.track5Playing == false)
            MusicNotes[3].SetActive(false);
        if (musicManager.track6Playing == false)
            MusicNotes[4].SetActive(false);
        if (musicManager.track7Playing == false)
            MusicNotes[5].SetActive(false);
    }
}
