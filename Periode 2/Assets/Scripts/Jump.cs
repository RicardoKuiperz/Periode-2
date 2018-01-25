using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public bool b;
    public Rigidbody r;
    public Vector3 height;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (b == true)
            if (Input.GetButtonDown("Jump") == true)
            {
                r.velocity = height;
                b = false;
            }
	}
    private void OnCollisionEnter(Collision collision)
    {

        b = true;
        
    }
}
