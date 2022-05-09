using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField]Unit unit;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = PlayerMon.GetPlayer().Unit.Health;
        slider.value = PlayerMon.GetPlayer().Unit.Health;
        Blast.enemydmg += HealthCond;
    }

    private void HealthCond() {
        print("set");
        
        slider.value = PlayerMon.GetPlayer().Unit.Health;
    }
}
