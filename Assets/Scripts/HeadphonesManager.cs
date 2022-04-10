using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadphonesManager : MonoBehaviour
{
    public UIManager uiManager;

    public SpriteRenderer noHeadphonesSpriteRenderer;
    public SpriteRenderer HeadphonesSpriteRenderer;
    public PlayerControllerTUTORIAL controller;

    public AudioSource sfxPlayer;
    public AudioClip powerupSFX;

    public GameObject HeadphonesToDestroy;

    private void Start()
    {
        uiManager.DisplayDialogueBox(1, 0);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            uiManager.canJump = true;
            uiManager.DisplayDialogueBox(1, 2);
            noHeadphonesSpriteRenderer.enabled = false;
            HeadphonesSpriteRenderer.enabled = true;
            controller.noHeadphones = false;
            sfxPlayer.clip = powerupSFX;
            sfxPlayer.Play();
            Object.Destroy(HeadphonesToDestroy);
        }
    }
}
