using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class PlayerMon : MonoBehaviour
{
    public static event UnityAction stats;
    private static PlayerMon instance;
    [SerializeField] private Image image;
    [SerializeField] private GameObject blast;
    GameObject unitObj;
    Unit unit;

    public GameObject UnitObj { get => unitObj; set { unitObj = value; OnUnitSet(); } }

    public Unit Unit { get => unit; set => unit = value; }

    public static PlayerMon GetPlayer() => instance;
    private void Awake() {

        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }


    }
    private void Start() {
        stats.Invoke();
    }
    void OnUnitSet() {
        //StartCoroutine(WaitForSet());
        Unit = unitObj.GetComponent<Unit>();
        Unit.SetStats();
        image.sprite =
            Unit.UnitSprite;
    }
    public void Attack() {

        Instantiate(blast, transform.position, Quaternion.identity);
    }
}
