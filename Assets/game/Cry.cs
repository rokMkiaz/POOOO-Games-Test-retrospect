using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cry : MonoBehaviour
{
    delegate void CryFunctionHandler();
    CryFunctionHandler cryFunctionHandler;

    [SerializeField] private Transform tearStart;
    [SerializeField] private GameObject tear;
    [SerializeField] private float cryDistance = 2.0f;
    [SerializeField] private float tearForce = 5.0f;
    [SerializeField] private Sprite lTearImage;
    [SerializeField] private Sprite RTearImage;

    Vector3 lefTeartPos;
    Vector3 rightTearPos;
    float startAngle =3.0f;
    void Awake()
    {
        lefTeartPos = new Vector3(tearStart.position.x - cryDistance, tearStart.position.y, tearStart.position.z);
        rightTearPos = new Vector3(tearStart.position.x + cryDistance, tearStart.position.y, tearStart.position.z);
        cryFunctionHandler = new CryFunctionHandler(TearCreat);

    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        cryFunctionHandler();

    }

    void TearCreat()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float zAngle = Random.Range(0.1f, 0.4f);
            int depth = Random.Range(0, 3);

            GameObject lTear = Instantiate(tear, lefTeartPos, Quaternion.Euler(0, 0, 0 - (zAngle * startAngle * 57.2958f)));
            GameObject rTear = Instantiate(tear, rightTearPos, Quaternion.Euler(0, 0, 0 + (zAngle * startAngle * 57.2958f)));

            lTear.transform.position = new Vector3(lTear.transform.position.x, lTear.transform.position.y, (float)depth);
            rTear.transform.position = new Vector3(rTear.transform.position.x, rTear.transform.position.y, (float)depth);


            lTear.transform.localScale = new Vector3(depth == 0 ? 0.65f : depth == 1 ? 0.7f : 0.75f, depth == 0 ? 0.65f : depth == 1 ? 0.7f : 0.75f, lTear.transform.localScale.z);
            rTear.transform.localScale = new Vector3(depth == 0 ? 0.65f : depth == 1 ? 0.7f : 0.75f, depth == 0 ? 0.65f : depth == 1 ? 0.7f : 0.75f, rTear.transform.localScale.z);

            lTear.GetComponent<SpriteRenderer>().sprite = lTearImage;
            rTear.GetComponent<SpriteRenderer>().sprite = RTearImage;

            Vector3 v2L = new Vector3(lefTeartPos.x - zAngle / 2, lefTeartPos.y + zAngle / 3, lefTeartPos.z);
            Vector3 v2R = new Vector3(rightTearPos.x + zAngle / 2, rightTearPos.y + zAngle / 3, rightTearPos.z);

            lTear.GetComponent<Rigidbody2D>().AddForce((v2L - tearStart.position) * (tearForce + zAngle), ForceMode2D.Impulse);
            rTear.GetComponent<Rigidbody2D>().AddForce((v2R - tearStart.position) * (tearForce + zAngle), ForceMode2D.Impulse);


        }
    }
}
