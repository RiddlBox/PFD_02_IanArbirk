using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontal



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Debug.lol Input.rawGetAxisRaw("Horizontal")
    }
    void FixedUpdate ()
    {

    }
}
