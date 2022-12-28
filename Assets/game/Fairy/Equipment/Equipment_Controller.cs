using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Equipment_Controller : MonoBehaviour
{
    public Equipment hat;
    public Equipment wing;
    public Equipment wand;

 
    void Start()
    {
        int num = 1;
        string s = "Level" + num + "_Hat";

        Invoke(s, 0.0f);
        //gameObject.AddComponent<Level1_Hat>();
        //hat = this.GetComponent<Level1_Hat>();
        

        if (hat != null) hat.InitSetting();
        if (wing != null) wing.InitSetting();
        if (wand != null) wand.InitSetting();
    }
    private void Level1_Hat()
    {
        gameObject.AddComponent<Level1_Hat>();
        hat = this.GetComponent<Level1_Hat>();
        hat.InitSetting();
    }
    private void Level2_Hat()
    {
        gameObject.AddComponent<Level2_Hat>();
        hat = this.GetComponent<Level2_Hat>();
        hat.InitSetting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
