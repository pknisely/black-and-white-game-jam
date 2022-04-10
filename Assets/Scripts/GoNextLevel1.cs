using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel1 : MonoBehaviour
{

    public UIManager uiManager;

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            uiManager.beatLevel1 = true;
            uiManager.DisplayDialogueBox(1, 3);
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
        }
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(2);
    }
}
