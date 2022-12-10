using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System.Linq;

public class PowerUp_List1 : MonoBehaviour
{
    private GameObject gameManager;

    [SerializeField] GameObject Mission;
    [SerializeField] GameObject Upgrade1;
    [SerializeField] GameObject Upgrade2;
    [SerializeField] GameObject Rock;


    [SerializeField] private TextMeshProUGUI UI_ListPower;
    [SerializeField] private TextMeshProUGUI UI_ListLevel;

    [SerializeField] private TextMeshProUGUI UI_PowerUp;
    [SerializeField] private TextMeshProUGUI UI_PowerUpMission;

    [SerializeField] private TextMeshProUGUI UI_RockMission;

    int myHealingPower;
    public int missionScore { get; set; }
  
    void Start()
    {
        gameManager= GameObject.Find("GameManager");
        myHealingPower = gameManager.GetComponent<UpgradeManager>().myHealingPower;
        UIUpdate();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(gameManager.GetComponent<GameManager>().healingPoint >= gameManager.GetComponent<UpgradeManager>().P_MissionPoint)
        {
            PowerUpMissionClear();
        }else
        {
            Upgrade1.SetActive(false);
            Upgrade2.SetActive(false);
        }
    }


    void PowerUpMissionClear()
    {
        Upgrade1.SetActive(true);
        Upgrade2.SetActive(true);
    }

    public void UpgradeClick()
    {
        gameManager.GetComponent<GameManager>().healingPoint -= gameManager.GetComponent<UpgradeManager>().P_MissionPoint;
        gameManager.GetComponent<UpgradeManager>().HealingPowerUp();


        gameManager.GetComponent<GameManager>().UIUpdate();
        UIUpdate();
    }
    void UIUpdate()
    {
        UI_ListPower.text = "탭당 치유력 "+ gameManager.GetComponent<UpgradeManager>().myHealingPower;
        //UI_ListLevel.text = "레벨" +1 ;
        UI_PowerUp.text = "+"+gameManager.GetComponent<UpgradeManager>().addHealingPower.ToString()+" 치유력";
        UI_PowerUpMission.text = gameManager.GetComponent<UpgradeManager>().P_MissionPoint.ToString(); ;
    }

    public void RockMissionClear()
    {

    }
}
