using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    public static event UnityAction<int> sendhp;
    Unit unit = new Unit();
    // Start is called before the first frame update
    void Start()
    {
        //UnitSelecter.selected+=SetUnit;
        print("ummm");
        unit.Health = 9;
        //sendhp.Invoke(unit.Health);
        if (sendhp != null) {
            sendhp(unit.Health);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUnit(Unit val) {
        unit = val;
    }
}
