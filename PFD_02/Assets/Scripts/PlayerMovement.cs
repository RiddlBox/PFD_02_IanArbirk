using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    // 12:21 https://www.youtube.com/watch?v=dwcT-Dch0bA 


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
     

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate () // Fixed update ideal for physics. Called a fixed amount of time pr. sec
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false); // Moving the character 
        jump = false;
    }
}