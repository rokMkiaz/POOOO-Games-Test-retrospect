using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스트레티지 패턴 연습

public struct Data
{
    public Sprite body;
    public    int fairy_HealingPower;
    public    int fairy_Healing_Level;
    public    int fairy_Healing_UpgradeCost;
    public  float fairy_Healing_Delay;
}
public struct Equipment
{
    public int hat_Level;
    public int wand_Level;
    public int wing_Level;

}


public abstract class Fairy : MonoBehaviour
{
    public Data data;
    public Equipment equipment;



    public abstract void InitSetting(); //순수가상함수 선언

    public virtual void InitEquipment()
    {


    }
    public virtual void Healing()
    {
        GameObject.Find("GameManager").GetComponent<UpgradeManager>().total_FairyHealingPower += data.fairy_HealingPower;
    }

    //public virtual void FairyOption(GameObject wing)
    //{
    //
    //}

}
