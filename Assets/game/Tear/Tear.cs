using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tear : MonoBehaviour
{
    

    public bool Left=true;
    private void Start()
    {
        if (transform.eulerAngles.z > 70) Left = true;
        else Left= false;

    }
    private void Update()
    {
        if(Left==true)transform.eulerAngles += new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0.9f);
        if(Left==false) transform.eulerAngles += new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -0.9f);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Ground0" && this.transform.position.z == 0)
        {
            Destroy(this.gameObject);
        }

        if (coll.tag == "Ground1" && this.transform.position.z == 1)
        {
            Destroy(this.gameObject);
        }

        if (coll.tag == "Ground2" && this.transform.position.z == 2)
        {
            Destroy(this.gameObject);
        }
    }



}
