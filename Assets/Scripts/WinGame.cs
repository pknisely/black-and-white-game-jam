using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;

    [SerializeField] private UIManager uImanager;


    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
            SceneManager.LoadScene(0);
        }
    }
}
