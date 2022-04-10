using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel2 : MonoBehaviour
{

    public UIManager uiManager;
    
    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            uiManager.beatLevel2 = true;
            uiManager.DisplayDialogueBox(2, 1);
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();

        }
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene(3);
    }

}
