using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnprop : MonoBehaviour {
    private Vector3 initialposition;
    private Quaternion initialrotation;
    public GameObject player;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialposition = this.transform.position;
        initialrotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y < 1)
        {
            this.transform.position = initialposition;
            this.transform.rotation = initialrotation;
            rb.isKinematic = true;
        }
        rb.isKinematic = false;
	}
}
