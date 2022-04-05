using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;

    // Run speed
    public float runSpeed = 40f;

    // Left or right movement 
    float horizontalMove = 0f;

    // Detects jumping
    bool jump = false;

    // Detects color change request
    bool changeColor = false;

    // audioSFX
    public AudioClip jumpSFX;
    public AudioClip swapSFX;
    public AudioSource sfxAudioSource;

    // Patrick adding colors
    // public Color colorOne;
    // public Color colorTwo;

    // Patrick adding a raycast to look down to see color of current platform
    // private Ray2D ray;
    // private RaycastHit2D hit;

    // public LayerMask floorMask;

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

        if (Input.GetKeyDown(KeyCode.F))
        {
            changeColor = true;
            sfxAudioSource.clip = swapSFX;
            sfxAudioSource.Play();
        }
/*
        hit = Physics2D.Raycast(controller.m_GroundCheck.position, -Vector2.up, 0.1f, floorMask);
        
        Debug.DrawLine(controller.m_GroundCheck.position, controller.m_GroundCheck.position - Vector3.up * 0.1f);
        if (hit)
        {
            if (!isColorOne && hit.transform.gameObject.GetComponent<Tile>().isColorOne)
                ChangeCollider("colorOne");
            else if (!isColorTwo && hit.transform.gameObject.GetComponent<Tile>().isColorTwo)
                ChangeCollider("colorTwo");
            else
            {
                GetComponent<BoxCollider2D>().enabled = true;
                GetComponent<CircleCollider2D>().enabled = true;
            }
        }
  */
    }



    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        if (changeColor == true)
        {
            controller.ChangeCollider(controller.isColorOne);
            changeColor = false;
        }
    }
}
