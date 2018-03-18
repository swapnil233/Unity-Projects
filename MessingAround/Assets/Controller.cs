using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float jumpSpeed;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float xSpeed = Input.GetAxis("Horizontal");
        float zSpeed = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(xSpeed, 0.0f, zSpeed);
        Vector3 jumpAction = new Vector3(0, jump, 0);

        GetComponent<Rigidbody>().AddForce(movement);

        rb.AddForce(movement * speed * Time.deltaTime);
        rb.AddForce(jumpAction * jumpSpeed * Time.deltaTime);
    }
}
