using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Equipment_Data
{
    public enum Slot
    {
        Hat,Wing, Wand
    }
    public struct Data
    {
        public Slot slot;
        public int slot_Level;
        public int add_Fairy_HealingPower;
    }
}


public abstract class Equipment : MonoBehaviour
{
    public Equipment_Data.Data data;

    public virtual void InitSetting()
    {
        data.slot_Level = 0;
        data.add_Fairy_HealingPower = 0;
    }

}
