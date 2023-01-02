using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Player_Anim : MonoBehaviour
{
    [SerializeField] GameObject sadFace;
    [SerializeField] GameObject arm;

    private Vector3 armStartPos;
    private bool sad=false;
    private float time=0.0f;
    private float timer=0.6f;

    private bool armAnim = false;
    private float armtime=0.0f;
    private float armspeed=0.01f;


    private void Start()
    {
        armStartPos = arm.transform.position;
    }
    void Update()
    {
        time += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))Sad();

        if (sad == true)
        {
            armtime += Time.deltaTime;
            if (armtime > 0.5f && armAnim !=true)
            {
                armAnim = true;
                armtime = 0.0f;

            }

            if(armAnim == true)arm.transform.position += new Vector3(0, armspeed, 0);
            if (armtime > 0.5f && armAnim==true)
            {
                armtime = 0.0f;
                armspeed *= -1;
            }
        }


        if (time > 0.3f)
        {
            sadFace.GetComponent<SpriteRenderer>().sortingOrder = -1;
            if (time > timer)
            {
                arm.transform.position = armStartPos;
                armAnim = false;
                armtime = 0.0f;
                armspeed = 0.001f;
            }
            sad = false;
        }
    }


    private void Sad()
    {
        sadFace.GetComponent<SpriteRenderer>().sortingOrder = 0;
        sad = true;
        time = 0.0f;
    }

}
