using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class UnitSelecter : MonoBehaviour
{
    public static event UnityAction<Unit> selected;
    private int g;
    [SerializeField] private Unit[] units;
    private int index=0;
    Unit currentUnit;
    // Start is called before the first frame update
    void Start()
    {
        currentUnit = units[index];
    }

    public void RightPress() {
        index++;
        if(index > 2) {
            index = 0;
        }

        currentUnit = units[index];
    }

    public void LeftPress() {

        index--;
        if (index < 0) {
            index = 2;
        }

        currentUnit = units[index];
    }

    public void SelectUnit() {

        selected.Invoke(currentUnit);
    }
}
