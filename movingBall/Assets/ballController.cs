using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public int multiplier = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        float Jump = Input.GetAxis("Jump");
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movehorizontal, Jump, movevertical);
        rb.AddForce(movement * multiplier);

    }
}