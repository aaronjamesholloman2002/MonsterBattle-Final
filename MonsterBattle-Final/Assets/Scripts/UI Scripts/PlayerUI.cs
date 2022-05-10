using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField] private Text textatt;
    [SerializeField] private Text textdef;
    [SerializeField] private Text textspd;
    // Start is called before the first frame update
    void Start() {
        slider.maxValue = PlayerMon.GetPlayer().Unit.Health;
        BattleManager.playerdmg += HealthCond;
        PlayerMon.stats += DisplayStats;
        BattleModeIcons.statsUp += DisplayStats;
        HealthCond();
        //DisplayStats();
    }

    private void HealthCond() {
        print("set");
        text.text = "Hp: " + PlayerMon.GetPlayer().Unit.Health.ToString();
        slider.value = PlayerMon.GetPlayer().Unit.Health;
    }
    private void DisplayStats() {
        slider.value = PlayerMon.GetPlayer().Unit.Health;
        text.text = "Hp: " + PlayerMon.GetPlayer().Unit.Health.ToString();
        textatt.text = "att: " + PlayerMon.GetPlayer().Unit.Attack.ToString();
        textdef.text = "def: " + PlayerMon.GetPlayer().Unit.Defense.ToString();
        textspd.text = "spd: " + PlayerMon.GetPlayer().Unit.Speed.ToString();
    }
}
