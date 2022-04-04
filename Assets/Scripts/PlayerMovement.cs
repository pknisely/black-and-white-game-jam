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

    // Patrick adding a boolean for color 1 or color 2
    [SerializeField] private bool isColorOne = true;
    [SerializeField] private bool isColorTwo = false;

    // Patrick adding colors
    public Color colorOne;
    public Color colorTwo;

    // Patrick adding sprites
    public Sprite colorOneSprite;
    public Sprite colorTwoSprite;

    // Patrick adding a raycast to look down to see color of current platform
    private Ray2D ray;
    private RaycastHit2D hit;
    public SpriteRenderer spriteRenderer;
    public LayerMask floorMask;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Pressed F");
            if (spriteRenderer.sprite == colorOneSprite)
            {
                spriteRenderer.sprite = colorTwoSprite;
                spriteRenderer.color = colorTwo;
                isColorTwo = true;
                isColorOne = false;
            }
            else if (spriteRenderer.sprite == colorTwoSprite)
            {
                spriteRenderer.sprite = colorOneSprite;
                spriteRenderer.color = colorOne;
                isColorTwo = false;
                isColorOne = true;
            }
        }

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
    }

 void ChangeCollider(string colorNumber)
    {
        if (colorNumber == "colorOne")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            Debug.Log("White box touching black platform!");
        }
        else if (colorNumber == "colorTwo")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            Debug.Log("Black box touching white platform!");
        }
    }

private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
