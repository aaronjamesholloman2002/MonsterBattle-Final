using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class UnitSelecter : MonoBehaviour
{
    public static event UnityAction<GameObject> selected;
    public static event UnityAction<Unit> currentUpdated;
    [SerializeField] private GameObject[] units;
    private int index = 0;
    GameObject currentUnit;

    public GameObject CurrentUnit { get => currentUnit; set { currentUnit = value; currentUpdated.Invoke(currentUnit.GetComponent<Unit>()); } }

    // Start is called before the first frame update
    void Start() {
        CurrentUnit = units[index];
    }

    public void RightPress() {
        index++;
        if (index > units.Length - 1) {
            index = 0;
        }

        CurrentUnit = units[index];
    }

    public void LeftPress() {

        index--;
        if (index < 0) {
            index = units.Length - 1;
        }

        CurrentUnit = units[index];
    }

    public void SelectUnit() {

        selected.Invoke(CurrentUnit);
    }
}