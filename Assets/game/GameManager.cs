using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UI_myHealingPoint;
    [SerializeField] private TextMeshProUGUI UI_myHealingPower;
    [SerializeField] private TextMeshProUGUI UI_myFairyPower;
    [SerializeField] private TextMeshProUGUI UI_jewel;

    private UpgradeManager myUpgrade;

    public int healingPoint { get; set; }
    void Awake()
    {
        myUpgrade = this.GetComponent<UpgradeManager>();

        healingPoint = myUpgrade.myHealingPoint;

        UI_myHealingPoint.text = "0";
        UI_myHealingPower.text = myUpgrade.myHealingPower.ToString();
        UI_myFairyPower.text = myUpgrade.myFairyPower.ToString();
        UI_jewel.text = myUpgrade.jewel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        AddHealingPoint();
    }


    private void AddHealingPoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            healingPoint += myUpgrade.myHealingPower;
            UIUpdate();
        }
    }
    
    public void UIUpdate()
    {
        UI_myHealingPoint.text = healingPoint.ToString();
        UI_myHealingPower.text = myUpgrade.myHealingPower.ToString();
        UI_myFairyPower.text = myUpgrade.myFairyPower.ToString();
        UI_jewel.text = myUpgrade.jewel.ToString();
    }
}
