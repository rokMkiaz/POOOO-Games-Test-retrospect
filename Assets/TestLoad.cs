using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Loader;
    private void Awake()
    {
        Instantiate(Loader);
    }
    void Start()
    {
      

        //if(Input.GetKeyDown(KeyCode.Space))
        SceneLoader.Instance.LoadScene("Maingame");
    }


}
