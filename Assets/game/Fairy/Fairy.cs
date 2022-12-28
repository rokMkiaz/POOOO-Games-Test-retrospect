using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ʈ��Ƽ�� ���� ����
namespace Fairy_Data
{
    public struct Data
    {
        public Sprite body;
        public int fairy_HealingPower;
        public int fairy_Healing_Level;
        public int fairy_Healing_UpgradeCost;
        public float fairy_Healing_Delay;

        public int fairy_TotalHeal;
    }
    public struct Equipment
    {
        public int hat_Level;
        public int wand_Level;
        public int wing_Level;

    }
}

public abstract class Fairy : MonoBehaviour
{
    public Fairy_Data.Data data;
    public Fairy_Data.Equipment equipment;



    public abstract void InitSetting(); //���������Լ� ����

    public virtual void InitEquipment()
    {


    }
    public virtual void Healing()
    {
        GameObject.Find("GameManager").GetComponent<UpgradeManager>().total_FairyHealingPower = data.fairy_TotalHeal;
    }

    //public virtual void FairyOption(GameObject wing)
    //{
    //
    //}

}
