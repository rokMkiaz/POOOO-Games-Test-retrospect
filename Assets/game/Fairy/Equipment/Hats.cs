using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_Hat : Equipment
{
    public override void InitSetting()
    {
        data.slot = Equipment_Data.Slot.Hat;
        data.slot_Level = 1;
        data.add_Fairy_HealingPower = 1;
    }
}
public class Level2_Hat : Equipment
{
    public override void InitSetting()
    {
        data.slot = Equipment_Data.Slot.Hat;
        data.slot_Level = 2;
        data.add_Fairy_HealingPower = 2;
    }
}