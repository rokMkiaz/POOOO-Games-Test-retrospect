using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_Fairy : Fairy
{
    public Sprite body;
    public override void InitSetting()
    {
        data.body = body;
        data.fairy_HealingPower=1;
        data.fairy_Healing_Level=1;
        data.fairy_Healing_UpgradeCost = 1;
        data.fairy_Healing_Delay = 1.0f;


        equipment.wing_Level = 0;
        equipment.hat_Level = 0;
        equipment.wand_Level = 0;
        this.GetComponent<SpriteRenderer>().sprite = data.body;
    }


}
