using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using static UnityEngine.GraphicsBuffer;

public class Tear : MonoBehaviour
{
    [SerializeField]private Transform my;
    ObjectPool objectPool;

    public bool Left=true;
    private void Start()
    {
        objectPool = GameObject.Find("Girl").GetComponent<ObjectPool>();

        //if (transform.eulerAngles.z > 70) Left = true;
        //else Left= false;

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
            initTear();
        }

        if (coll.tag == "Ground1" && this.transform.position.z == 1)
        {
            initTear();
        }

        if (coll.tag == "Ground2" && this.transform.position.z == 2)
        {
            initTear();
        }
    }

    private void initTear()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        objectPool.objectPoolList[0].Enqueue(this.gameObject);
        this.gameObject.SetActive(false);
    }


}
