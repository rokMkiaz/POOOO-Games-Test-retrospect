using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    delegate void GameManagerFunction();
    GameManagerFunction gameManagerFunction;

    [SerializeField] private TextMeshProUGUI UI_myHealingPoint;
    [SerializeField] private TextMeshProUGUI UI_myHealingPower;
    [SerializeField] private TextMeshProUGUI UI_myFairyPower;
    [SerializeField] private TextMeshProUGUI UI_jewel;

    private UpgradeManager myUpgrade;

    float time = 0.0f;
    float delay = 1.0f;

    public int healingPoint { get; set; }
    void Awake()
    {
        myUpgrade = this.GetComponent<UpgradeManager>();

        healingPoint = myUpgrade.myHealingPoint;

        UI_myHealingPoint.text = "0";
        UI_myHealingPower.text = myUpgrade.myHealingPower.ToString();
        UI_myFairyPower.text = myUpgrade.myFairyPower.ToString();
        UI_jewel.text = myUpgrade.jewel.ToString();

        gameManagerFunction = new GameManagerFunction(AddHealingPoint);
        gameManagerFunction += new GameManagerFunction(FairyHeal);
        gameManagerFunction += new GameManagerFunction(UIUpdate);
    }

    
    void Update()
    {
        gameManagerFunction();
    }


    private void AddHealingPoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            healingPoint += myUpgrade.myHealingPower;
        }
    }
    private void FairyHeal()
    {
        time += Time.deltaTime;
        if(time>delay)
        {
            healingPoint += myUpgrade.total_FairyHealingPower;
            time = 0.0f;
        }
    }
    
    public void UIUpdate()
    {
        UI_myHealingPoint.text = healingPoint.ToString();
        UI_myHealingPower.text = myUpgrade.myHealingPower.ToString();
        UI_myFairyPower.text = myUpgrade.total_FairyHealingPower.ToString();
        UI_jewel.text = myUpgrade.jewel.ToString();
    }
}
