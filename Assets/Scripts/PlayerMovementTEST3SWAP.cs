using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementTEST3SWAP : MonoBehaviour
{
    public PlayerControllerTEST3SWAP controller;

    // Run speed
    public float runSpeed = 40f;

    // Left or right movement 
    float horizontalMove = 0f;

    // Detects jumping
    bool jump = false;

    // Detects color change request
    bool changeColor = false;
    bool changeColorBackwards = false;

    // audioSFX
    public AudioClip jumpSFX;
    public AudioClip swapSFX;
    public AudioSource sfxAudioSource;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            if (controller.m_Grounded == true)
            {
                sfxAudioSource.clip = jumpSFX;
                sfxAudioSource.Play();
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            changeColor = true;
            sfxAudioSource.clip = swapSFX;
            sfxAudioSource.Play();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            changeColorBackwards = true;
            sfxAudioSource.clip = swapSFX;
            sfxAudioSource.Play();
        }
    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        if (changeColor == true)
        {
            controller.ChangeCollider(controller.currentColor);
            changeColor = false;
        }
        if (changeColorBackwards == true)
        {
            controller.ChangeColliderBackwards(controller.currentColor);
            changeColorBackwards = false;
        }
    }
}
