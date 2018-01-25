using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RaycastTest : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject particle;
    public int count;
    public Text countText;

    // Use this for initialization
    void Start()
    {
        count = 0;
        setCountText();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward * 1000f, Color.green);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1000f))
            {
                if (hit.transform.tag == "Bal")
                {
                    GameObject g = Instantiate(particle, hit.point, Quaternion.identity);
                    Destroy(g, 1);
                    hit.transform.gameObject.GetComponent<Health>().loseHP(10);
                    if (hit.transform.gameObject.GetComponent<Health>().HP <= 0)
                        {
                            count += 1;
                            setCountText();
                        }
                }
            }
        }
    }
    public void setCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
