using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject sphere;
    Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - sphere.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
