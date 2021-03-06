using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTUTORIAL : MonoBehaviour
{
    public PlayerControllerTUTORIAL controller;
    public UIManager uiManager;

    // Run speed
    public float runSpeed = 40f;

    // Left or right movement 
    float horizontalMove = 0f;

    // Detects jumping
    bool jump = false;

    // audioSFX
    public AudioClip jumpSFX;
    public AudioClip swapSFX;
    public AudioSource sfxAudioSource;

    public GameObject whiteHeadphones;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump") && controller.noHeadphones == false)
        {
            jump = true;
            if (controller.m_Grounded == true)
            {
                sfxAudioSource.clip = jumpSFX;
                sfxAudioSource.Play();
            }
        }

        if (controller.noHeadphones == false)
            uiManager.canJump = true;
    }

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
