using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class UnitSelecter : MonoBehaviour
{
    public static event UnityAction<Unit> selected;
    public static event UnityAction<Unit> currentUpdated;
    private int g;
    [SerializeField] private Unit[] units;
    private int index=0;
    Unit currentUnit;

    public Unit CurrentUnit { get => currentUnit; set { currentUnit = value;currentUpdated.Invoke(currentUnit); } }

    // Start is called before the first frame update
    void Start()
    {
        CurrentUnit = units[index];
    }

    public void RightPress() {
        index++;
        if(index > units.Length-1) {
            index = 0;
        }

        CurrentUnit = units[index];
    }

    public void LeftPress() {

        index--;
        if (index < 0) {
            index = units.Length-1;
        }

        CurrentUnit = units[index];
    }

    public void SelectUnit() {

        selected.Invoke(CurrentUnit);
    }
}
