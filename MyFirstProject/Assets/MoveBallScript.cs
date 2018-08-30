using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 vel = rb.velocity;
            vel.x += 2;
            rb.velocity = vel;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 vel = rb.velocity;
            vel.x -= 2;
            rb.velocity = vel;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 vel = rb.velocity;
            vel.z -= 2;
            rb.velocity = vel;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 vel = rb.velocity;
            vel.z += 2;
            rb.velocity = vel;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
