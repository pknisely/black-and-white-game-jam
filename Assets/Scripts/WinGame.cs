using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    public UIManager uiManager;
    public RecordManager recordManager;

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;

    bool newRecord;


    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            newRecord = recordManager.GetTimeFinished();
            uiManager.beatLevel3 = true;
            if (newRecord == true)
            { 
                uiManager.DisplayDialogueBox(3, 1);

            }
            else
            {
                uiManager.DisplayDialogueBox(3, 2);
            }
            
                sfxPlayer.clip = powerupSFX;
                sfxPlayer.Play();
            }
    }

    public void GoCredits()
    {
        uiManager.DisplayDialogueBox(3, 3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}