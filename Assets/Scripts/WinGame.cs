using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    public UIManager uiManager;

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;


    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            uiManager.beatLevel3 = true;
            uiManager.DisplayDialogueBox(3, 1);
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
        }
    }

    public void GoCredits()
    {
        SceneManager.LoadScene(0);
    }

}
