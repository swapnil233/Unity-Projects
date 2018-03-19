using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float multiplier;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {     
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(xSpeed, jump, ySpeed);
        rb.AddForce(movement * multiplier);
    }
}
