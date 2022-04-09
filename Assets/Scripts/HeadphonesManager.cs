using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadphonesManager : MonoBehaviour
{

    public SpriteRenderer noHeadphonesSpriteRenderer;
    public SpriteRenderer HeadphonesSpriteRenderer;
    public PlayerControllerTUTORIAL controller;

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;

    public GameObject HeadphonesToDestroy;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            noHeadphonesSpriteRenderer.enabled = false;
            HeadphonesSpriteRenderer.enabled = true;
            controller.noHeadphones = false;
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
            Object.Destroy(HeadphonesToDestroy);
        }
    }
}
