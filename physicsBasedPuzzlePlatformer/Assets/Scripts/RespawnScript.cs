using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {
    private Vector3 initialposition;
            private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        initialposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0)
        {
            transform.position = initialposition;
            rb.isKinematic = true; // disables physics temporarily(removes momentum)
        }
        rb.isKinematic = false; // allows movement again
	}
}
