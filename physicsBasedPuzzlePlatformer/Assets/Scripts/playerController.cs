﻿using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speedNum;

    //Character Controller
    private CharacterController controller;
    private float verticalVelocity;
    private float gravity = 250.0f;
    private float jumpForce = 5.0f;

    //Rigid Body 
    public Rigidbody rb;

    public LayerMask groundLayers;
    public SphereCollider col;

    public float multiplier;

    //Game object 
    public GameObject ball;

    //Check for respawn
    private bool belowground;

    // Use this for initialization
    void Start()
    {
        belowground = false;

        //Initializing rigid body and char controller @ the start
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();



        //controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Respawn function
        if (ball.transform.position.y < 0)
        {
            belowground = true;
        }

        if (belowground == true)
        {
            ball.transform.position = new Vector3(-2, 5, -8);
            belowground = false;
        }
        */

        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        //Ball Movement
        Vector3 movement = new Vector3(xSpeed, 0, ySpeed);
        rb.AddForce(movement * speedNum);

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//impulse adds this amount of force once instead of over a period of time

        }


        //Alternate moving script

        /*
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //Moving and jumping 
        Vector3 moveVector = Vector3.zero;

        moveVector.x = Input.GetAxis("Horizontal") * 5.0f;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Vertical") * 5.0f;
        controller.Move(moveVector * Time.deltaTime);
        */

    }

    private bool isGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3 (col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), 
            col.radius * 9, groundLayers);
    }
}