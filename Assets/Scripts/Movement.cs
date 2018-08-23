using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody rb;
    public float speed;
    public float turnSpeed;   
  
	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        rb.AddForce(movement, ForceMode.Acceleration);

	}
}
