using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUp : MonoBehaviour {
    public Vector3 viewUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        viewUp.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(viewUp);
		
	}
}
