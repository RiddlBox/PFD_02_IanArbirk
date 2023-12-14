using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runspeed = 40f;
    float horizontalMove = 0f;
    //12:21 https://www.youtube.com/watch?v=dwcT-Dch0bA 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.rawGetAxisRaw("Horizontal");
    }
    void FixedUpdate ()
    {
        controller.Move(horizontalMove, false, false);
    }
}
