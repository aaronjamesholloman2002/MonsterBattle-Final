using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField] private Text textatt;
    [SerializeField] private Text textdef;
    [SerializeField] private Text textspd;
    [SerializeField] Unit unit;
    // Start is called before the first frame update
    void Start() {
        slider.maxValue = EnemyMn.GetBoss().Unit.Health;
        BattleManager.enemydmg += HealthCond;
        HealthCond();
        BattleManager.newPhase += DisplayStats;
    }

    private void HealthCond() {
        print("set");
        text.text = "Hp: " + EnemyMn.GetBoss().Unit.Health.ToString();
        slider.value = EnemyMn.GetBoss().Unit.Health;
    }
    private void DisplayStats() {
        textatt.text = "att: " + EnemyMn.GetBoss().Unit.Attack.ToString();
        textdef.text = "def: " + EnemyMn.GetBoss().Unit.Defense.ToString();
        textspd.text = "spd: " + EnemyMn.GetBoss().Unit.Speed.ToString();
    }
}
