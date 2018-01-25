using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunFire : MonoBehaviour {
    public bool shoot;
    public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject.Find("Gun").GetComponent<Animator>().SetBool("shoot", true);
            shoot = true;
        }

        if (shoot == true)
        {
            timer += Time.deltaTime;
            if(timer >= 0.60f)
            {
                shoot = false;
                timer = 0;
            }
        }

        if(Input.GetButtonUp("Fire1"))
        {
            GameObject.Find("Gun").GetComponent<Animator>().SetBool("shoot", true);
            
        }
    
		

    }
}
