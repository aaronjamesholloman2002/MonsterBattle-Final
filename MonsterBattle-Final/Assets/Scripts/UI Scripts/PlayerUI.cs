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
        Player.sendhp += HealthCond;
    }

    private void HealthCond(int value) {
        print("set");
        slider.maxValue = value;
        slider.value = value;
    }
}
