using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public int HP;
    public int Score;
    public GameObject enemy;
    public Vector3 V;



	// Use this for initialization
	void Start () {
        Score = 0;
   
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Damage
    public void loseHP(int dmg)
    {
        HP -= dmg;
        if (HP <= 0)
        {
           
            Destroy(gameObject);
            {
                Instantiate(enemy, V, Quaternion.identity);
                print("spawn");
            }
            {

                print(Score);
            }
        }
    }
    

}

