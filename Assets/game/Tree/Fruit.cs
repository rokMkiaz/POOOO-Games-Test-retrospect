using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    RaycastHit2D hit;
 
    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            BoolOnonSelected();
          
        }
     
    }
    void BoolOnonSelected()
    {
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Fruit")
            {
                this.GetComponent<GameManager>().healingPoint += this.GetComponent<UpgradeManager>().myHealingPower * 10;
                GameObject.Find("GameManager").GetComponent<GameManager>().UIUpdate();
                Destroy(hit.collider.gameObject);
            }
        }


    }
}
