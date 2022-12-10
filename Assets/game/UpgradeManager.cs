using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int myHealingPoint { get; private set; }
    public int myHealingPower { get; private set; }
    public int myFairyPower { get; private set; }
    public int jewel { get; private set; }


    //PowerUpList
    public int addHealingPower = 1;
    public int P_MissionPoint = 10;
    //FairyUpList
    public int addFairyHealingPower;
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
        myHealingPower += addHealingPower;
        P_MissionPoint *= 2;
        addHealingPower *= 2;
        this.GetComponent<GameManager>().UIUpdate();
    }

    public void FairyPowerUp()
    {
        myFairyPower += addFairyHealingPower;
        F_MissionPoint *= 2;
        addFairyHealingPower *=2;
    }
}
