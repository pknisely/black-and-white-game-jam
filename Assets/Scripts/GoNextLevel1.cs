using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel1 : MonoBehaviour
{

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
            SceneManager.LoadScene(2);
        }
    }

}
