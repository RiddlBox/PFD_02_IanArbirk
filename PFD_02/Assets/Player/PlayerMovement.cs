using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    // 12:21 https://www.youtube.com/watch?v=dwcT-Dch0bA 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }
    void FixedUpdate () // Fixed update ideal for physics. Called a fixed amount of time pr. sec
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false); // Moving the character 
    }
}
