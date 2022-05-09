using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField] Unit unit;
    // Start is called before the first frame update
    void Start() {
        slider.maxValue = EnemyMn.GetBoss().unit.Health;
        Blast.playerdmg += HealthCond;
    }

    private void HealthCond() {
        print("set");

        slider.value = EnemyMn.GetBoss().unit.Health;
    }
}
