using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour {
    public Vector3 rotation;
    public Vector3 move;
    public Vector3 view;
    public GameObject cam;
    public float x;
    public float z;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(move*Time.deltaTime*speed);
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move.z = z;
        move.x = x;

        //Rotation
        view.y = Input.GetAxis("Mouse X");        
        transform.Rotate(view);

        //mouse lock
        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        //Mouse Unlock
        if (Input.GetButton("Escape"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
