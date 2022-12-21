using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy_Controller : MonoBehaviour
{
    public GameObject wing;
    public GameObject hat;
    public GameObject wand;

    public List<RuntimeAnimatorController> wing_List;
    public List<Sprite> hat_List;
    public List<Sprite> wand_List;


    public Fairy myfairy;

  

    void Start()
    {
        myfairy.InitSetting();
        myfairy.Healing();

        wing.GetComponent<Animator>().runtimeAnimatorController = wing_List[myfairy.equipment.wing_Level];
        hat.GetComponent<SpriteRenderer>().sprite = hat_List[myfairy.equipment.hat_Level];
        wand.GetComponent<SpriteRenderer>().sprite = wand_List[myfairy.equipment.wand_Level];


    }

  
    void Update()
    {
        
    }

    public void UpdateEquipment()
    {
        wing.GetComponent<Animator>().runtimeAnimatorController = wing_List[myfairy.equipment.wing_Level];
        hat.GetComponent<SpriteRenderer>().sprite = hat_List[myfairy.equipment.hat_Level];
        wand.GetComponent<SpriteRenderer>().sprite = wand_List[myfairy.equipment.wand_Level];
    }
}
