using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMon : MonoBehaviour
{
    private static PlayerMon instance;
    [SerializeField]private Image image;
    [SerializeField] private GameObject blast;
    private int attBoost;
    private int defBoost;
    private int spdBoost;
    Unit unit = new Unit();

    public Unit Unit { get => unit; set { unit = value; OnUnitSet(); } }
    public static PlayerMon GetPlayer() => instance;
    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }

    }
    void Start()
    {
        Unit.Start();
    }
    void OnUnitSet() {
        //StartCoroutine(WaitForSet());
        image.sprite = 
            Unit.UnitSprite;
    }
    public void Attack() {

        Instantiate(blast, transform.position, Quaternion.identity);
    }
    IEnumerator WaitForSet() { 
    yield return null;
       
    }
}
