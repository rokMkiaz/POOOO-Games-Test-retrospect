using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
  


    private Ray ray; 
    private Vector3 direction; 
    private float distance=0.0f;

 
    void Update()
    {
 
     
        ray = new Ray(this.transform.position, direction);

        //RaycastHit hit
        if (Physics.Raycast(ray,distance)) //out, Trigger no
        {
     
           // if(hit.collider.gameObject != Target.gameObject)
           // {
           //    
           // }

        }
    }

    //private void OnDrawGizmos() //Gizmo
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(ray.origin, direction.normalized*distance); 
    //}
}
