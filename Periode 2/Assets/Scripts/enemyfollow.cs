using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public int speed;
    public GameObject Go;

    // Use this for initialization
    void Start()
    {
        Go = GameObject.FindGameObjectWithTag("player");
    }

    



    void Update()
    {

        transform.LookAt(Go.transform.position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
