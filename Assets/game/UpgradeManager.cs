using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int myHealingPoint { get; private set; }
    public int myHealingPower { get; set; }
    public int myFairyPower { get;  set; }
    public int jewel { get; private set; }


    //PowerUpList
    public int total_ClickHealingPower = 1;
    public int P_MissionPoint = 10;
    //FairyUpList
    public int total_FairyHealingPower { get; set; }
    public int F_MissionPoint;




    void Awake()
    {
        myHealingPoint = 0;
        myHealingPower = 1;
        myFairyPower = 0;
        jewel = 0;

    }

    void Update()
    {

    }

    public void HealingPowerUp()
    {
        myHealingPower += total_ClickHealingPower;
        P_MissionPoint *= 2;
        total_ClickHealingPower *= 2;
        this.GetComponent<GameManager>().UIUpdate();
    }


}
