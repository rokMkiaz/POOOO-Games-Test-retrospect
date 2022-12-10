using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UI_Click : MonoBehaviour
{
    public GameObject L_PowerUp;
    public RectTransform R_PowerUp;

    public GameObject L_Fairy;
    public RectTransform R_Fairy;

    public GameObject L_Tree;
    public RectTransform R_Tree;


    public GameObject UpBotton;
    public GameObject DownBotton;

    public GameObject storeMenu;
    public RectTransform storeTransform;


    int storeNum=0;
     bool storeSwitch=false;
    bool OpenSwitch = false;
    float speed = 0.07f;

    float timer = 0.0f;
    float timeOver = 0.85f;

    Vector3 menuStartPos;
    Vector3 storeStartPos;
 
    private void Awake()
    {
        menuStartPos = storeMenu.transform.position;
        storeStartPos = storeTransform.position;
    }

    private void FixedUpdate()
    {
        if(storeSwitch==true)
        {
            timer += Time.deltaTime;
            StoreOpen();

            if(timer>timeOver)
            {
                storeSwitch = false;
                if (OpenSwitch == false)
                {
                    OpenSwitch = true;
                    UpBotton.SetActive(false);
                    DownBotton.SetActive(true);
                }else if (OpenSwitch == true)
                {
                    StoreClose();
                    DownBotton.SetActive(false);
                    UpBotton.SetActive(true);
                }
                speed *= -1.0f;
                timer = 0.0f;

            }

        }
    }


    public void PowerUp_Active()
    {


        L_PowerUp.SetActive(true);
        L_Fairy.SetActive(false);
        L_Tree.SetActive(false);
        storeNum = 0;
        //if(OpenSwitch!=true)StoreUp();
        if(OpenSwitch == false)storeSwitch = true;


    }

    public void Fairy_Active()
    {
       L_PowerUp.SetActive(false);
       L_Fairy.SetActive(true);
       L_Tree.SetActive(false);


        storeNum = 1;
        if (OpenSwitch == false) storeSwitch = true;
   
    }
    public void Tree_Active()
    {
        L_PowerUp.SetActive(false);
        L_Fairy.SetActive(false);
        L_Tree.SetActive(true);

        storeNum = 2;
        if (OpenSwitch == false) storeSwitch = true;
  
    }

    public void StoreUp()
    {
         storeSwitch = true;

         if (storeNum == 0) PowerUp_Active();
         else if (storeNum == 1) Fairy_Active();
         else if (storeNum == 2) Tree_Active();
        
    }

    public void StoreClose()
    {
        OpenSwitch = false;

        R_PowerUp.position = new Vector3(R_PowerUp.position.x, storeStartPos.y);
        R_Fairy.position = new Vector3(R_Fairy.position.x, storeStartPos.y);
        R_Tree.position = new Vector3(R_Tree.position.x, storeStartPos.y);

        L_PowerUp.SetActive(false);
        L_Fairy.SetActive(false);;
        L_Tree.SetActive(false);

        storeMenu.transform.position = menuStartPos;
   

    }


    private void StoreOpen()
    {
        if (R_PowerUp != null) R_PowerUp.position = new Vector3(R_PowerUp.position.x, storeTransform.position.y);
        if (R_Fairy != null) R_Fairy.position = new Vector3(R_Fairy.position.x, storeTransform.position.y);
        if (R_Tree != null) R_Tree.position = new Vector3(R_Tree.position.x, storeTransform.position.y);
        storeMenu.gameObject.transform.position += new Vector3(0, speed, 0.0f);



    }
}
