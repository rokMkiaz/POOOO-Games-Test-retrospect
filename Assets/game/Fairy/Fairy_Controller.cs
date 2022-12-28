using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fairy_Controller : MonoBehaviour
{
    public delegate void FairyFunctionHandler();
    FairyFunctionHandler fairyFunctionHandler;

    public GameObject wing;
    public GameObject hat;
    public GameObject wand;

    public List<RuntimeAnimatorController> wing_List;
    public List<Sprite> hat_List;
    public List<Sprite> wand_List;

    public Fairy myfairy;

    private Equipment_Controller equipment_Controller;




    void Awake()
    {
        equipment_Controller = this.GetComponent<Equipment_Controller>();
        fairyFunctionHandler = new FairyFunctionHandler(MyfairySetting);
    }
    void Start()
    {
        fairyFunctionHandler();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) fairyFunctionHandler();
    }

    void MyfairySetting()
    {
        myfairy.InitSetting();
        UpdateEquipment();
        myfairy.Healing();
    }
    public void UpdateEquipment()
    {
        if (equipment_Controller.wing != null) myfairy.equipment.wing_Level =  equipment_Controller.wing.data.slot_Level ;
        if(equipment_Controller.hat!=null)myfairy.equipment.hat_Level =equipment_Controller.hat.data.slot_Level;
        if (equipment_Controller.wand != null) myfairy.equipment.wand_Level = equipment_Controller.wand.data.slot_Level ;

        wing.GetComponent<Animator>().runtimeAnimatorController = wing_List[myfairy.equipment.wing_Level];
        hat.GetComponent<SpriteRenderer>().sprite = hat_List[myfairy.equipment.hat_Level];
        wand.GetComponent<SpriteRenderer>().sprite = wand_List[myfairy.equipment.wand_Level];

        //ÅäÅ» Èú = ¸Ó¸®+³¯°³+¿Ïµå
        myfairy.data.fairy_TotalHeal = myfairy.data.fairy_HealingPower + equipment_Controller.wing.data.add_Fairy_HealingPower
            + equipment_Controller.hat.data.add_Fairy_HealingPower + equipment_Controller.wand.data.add_Fairy_HealingPower;
    }
}
