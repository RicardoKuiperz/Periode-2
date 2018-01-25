using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public float damg;

	// Use this for initialization
	void Start () {
        damg = ExtDamg(10);
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    public float ExtDamg(float damg)
    {
        return damg * 5f;
    }
}
