using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    // Objects to hold images of the Hud -- Array of music notes, an array of headphones, and the record
    public GameObject[] MusicNotes;
    public GameObject[] Headphones;
    public GameObject Record;

    // Accessible music manager for values from heighth of player
    public MusicManager musicManager;

    // UI elements to pop up the dialogue boxes
    [SerializeField] private TMPro textbox;
    [SerializeField] private TMPro about;
    [SerializeField] private TMPro controls;
    [SerializeField] private GameObject DialogueBox;

    private string about =
"Ideally we’d have a nice animation, but this paragraph will have to suffice. Happy the robot wants nothing more than to listen to his records on his headphones and enjoy his life.But sometimes the world isn’t fair. Help Happy get his headphones and his record back!
    CREDITS:
    Eber Alegria
    Bent Neatly
    Patrick Knisely (Pdyx)";
    private string controls;
    private string gotBlackHeadphones = "You got the black headphones! You can jump!"
    private string gotWhiteHeadphones = "You got the white headphones! You can jump higher and swap!"
    private string gotGrayHeadphones = "You got the gray headphones! You can jump higher and swap backwards!"
    private string gotRecord = "You got the record!";
    private string didntGetRecord = "You didn't get the record...";

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
        if (beatLevel1 == true)
            Headhpones.SecActive(true);
        if (beatLevel2 == true)
            Headphones.SetActive(true);
        if (beatLevel3 == true) 
            Record.SetActive(true);

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

    void DisplayDialogueBox(int level, int occ)
    {
            Time.timeScale = 0;
            DialogueBox.SetActive(true);
            Cursor.visible = true;
            switch (level) 
        {
            case 0:
                {
                    about = "Ideally we’d have a nice animation, but this paragraph will have to suffice. Happy the robot wanted nothing more than to listen to his records on his headphones. But sometimes the world isn’t fair. Help Happy get his headphones and his record back!


    CREDITS:
                    Eber Alegria
    Bent Neatly
    Patrick Knisely(Pdyx)
"
                }
            case 1:
                {
                   switch (occ)
                    {
                        case 0:
                            {
                                controls = "";
                                break;
                            }
                        case 1:
                            {
                                
                                textBox.SetActive();
                                = "You got the black headphones! Now you can jump!";
                                break;
                            }
                        case 2:
                            {
                                textBox = "You got the white headphones! Now you can swap!";
                                break;
                            }
                    }
                    break;

                }

            case 2:
                {
                    switch (occ)
                    {
                        case 0:
                            {
                                controls = "";
                                break;
                            }
                        case 1:
                            {
                                textBox = "You got the gray headphones!Now you can swap backwards too!";
                                break;
                            }
                }
            case 3:
                {
                    switch (occ)
                    {
                        case 0:
                            {
                                controls = "";
                            }
                        case 1:
                            {
                                //                if (time >= recordtextBox)
                                textBox = "You got the record!";
                                //                else
                                //                  textBox = "You didn’t get the record…";
                                break;
                            }
                    }
                }
}
