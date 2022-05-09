using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        Player.sendhp += HealthCond;
=======
        slider.maxValue = PlayerMon.GetPlayer().Unit.Health;
        BattleManager.playerdmg += HealthCond;
>>>>>>> Stashed changes
    }

    private void HealthCond(int value) {
        print("set");
        slider.maxValue = value;
        slider.value = value;
    }
}
