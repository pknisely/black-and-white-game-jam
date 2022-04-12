using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Objects to hold images of the Hud -- Array of music notes, an array of headphones, and the record
    public GameObject[] MusicNotes;
    public GameObject[] Headphones;
    public GameObject GoalObject;

    // RecordManager for getting the current time for the UI
    // UI Box for displaying the current time

    public RecordManager recordManager;
    [SerializeField] private TMP_Text currentTimeBox;

    // Accessible music manager for values from heighth of player
    public MusicManager musicManager;

    // UI elements to pop up the dialogue boxes
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private TMP_Text textBoxTwo;
    [SerializeField] private TMP_Text controls;
    [SerializeField] private GameObject DialogueBox;
    [SerializeField] private GameObject DialogueBoxTwo;

    // Strings for text boxes

    private string introScreen = "Someone has taken Happy the Robot's headphones and record!\n\nCan you recover the headphones and get the record?\n\nPress the 'p' key on the keyboard to pause at any time and see the controls.";
    private string gotBlackHeadphones = "You got the black headphones!\n\nYou can jump!";
    private string gotWhiteHeadphones = "You got the white headphones!\n\nYou can jump higher and swap!";
    private string gotGrayHeadphones = "You got the gray headphones! You can jump higher and swap backwards!";
    private string gotRecord = "You got the record! Congratulations! The new record is ";
    private string gotRecordPart2 = ".";
    private string didntGetRecord = "You didn't get the record... The current record is ";
    private string didntGetRecordPart2 = ". You finished in ";
    private string didntGetRecordPart3 = ". Maybe try again?";
    private string credits = "Thanks for playing!\n\nCREDITS\nEber Alegria\nBent Neatly\nPatrick Knisely aka Pdyx\n\nIf you enjoyed the game and want to see more of Happy, please let us know!\n\npdyx123@gmail.com";


    // bools for item obtaining

    public bool canJump = false;
    public bool beatLevel1 = false;
    public bool beatLevel2 = false;
    public bool beatLevel3 = false;

    // Start method
    private void Start()
    {
        if (canJump == true)
            Headphones[0].SetActive(true);
        if (beatLevel1 == true)
            Headphones[1].SetActive(true);
        if (beatLevel2 == true)
            Headphones[2].SetActive(true);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            canJump = true;
            beatLevel1 = true;
            beatLevel2 = true;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            canJump = true;
            beatLevel1 = true;
        }
    }

        // Update is called once per frame
    private void Update()
    {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
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

                if (beatLevel3 == true)
                    GoalObject.SetActive(true);
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
            {
                canJump = true;
                beatLevel1 = true;

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

                if (beatLevel2 == true)
                    GoalObject.SetActive(true);
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
            {
                if (canJump == true)
                Headphones[0].SetActive(true);

                // Check for if you're high enough for each musical note to appear
                if (musicManager.track2Playing == true)
                    MusicNotes[0].SetActive(true);
                if (musicManager.track3Playing == true)
                    MusicNotes[1].SetActive(true);
                if (musicManager.track4Playing == true)
                    MusicNotes[2].SetActive(true);

                // Check for if you're low enough for each musical note to disappear
                if (musicManager.track2Playing == false)
                    MusicNotes[0].SetActive(false);
                if (musicManager.track3Playing == false)
                    MusicNotes[1].SetActive(false);
                if (musicManager.track4Playing == false)
                    MusicNotes[2].SetActive(false);

                if (beatLevel1 == true)
                    GoalObject.SetActive(true);

            }

        currentTimeBox.text = recordManager.DisplayCurrentTime();

     }

    public void DisplayDialogueBox(int level, int occ)
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        switch (level)
        {
            case 1:
                {
                    switch (occ)
                    {
                        case 0:
                            {
                                Cursor.visible = true;
                                DialogueBox.SetActive(true);
                                textBox.text = introScreen;
                                break;
                            }
                        case 1:
                            {
                                // CursorOn()
                                //                               controls = "";
                                break;
                            }
                        case 2:
                            {
                                CursorOn();
                                DialogueBox.SetActive(true);
                                textBox.text = gotBlackHeadphones;

                                break;
                            }
                        case 3:
                            {
                                CursorOn();
                                DialogueBoxTwo.SetActive(true);
                                textBoxTwo.text = gotWhiteHeadphones;
                                break;
                            }
                    }
                    break;
                }

            case 2:
                {
                    switch (occ)
                    {
                        case 1:
                            {
                                CursorOn();
                                DialogueBoxTwo.SetActive(true);
                                textBoxTwo.text = gotGrayHeadphones;
                                break;
                            }
                    }
                    break;
                }

            case 3:
                {
                    switch (occ)
                    {
                        case 0:
                            {
                                break;
                            }
                        case 1:
                            {
                                CursorOn();
                                DialogueBox.SetActive(true);
                                textBox.text = gotRecord + recordManager.DisplayCurrentRecord() + gotRecordPart2;
                                break;
                            }
                        case 2:
                            {
                                CursorOn();
                                DialogueBox.SetActive(true);
                                textBox.text = didntGetRecord + recordManager.DisplayCurrentRecord() + didntGetRecordPart2 + recordManager.DisplayFinishedTime() + didntGetRecordPart3;
                                break;
                            }
                        case 3:
                            {
                                CursorOn();
                                DialogueBoxTwo.SetActive(true);
                                textBoxTwo.text = credits;
                                break;
                            }
                    }
                    break;
                }
        }
    }

    public void CursorOn()
    {
        Cursor.visible = true;
    }

    public void CursorOff()
    {
        Cursor.visible = false;
    }

}

