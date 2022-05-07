using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMon : MonoBehaviour
{
    private static PlayerMon instance;
    [SerializeField]private Image image;
    Unit unit = new Unit();

    public Unit Unit { get => unit; set { unit = value; oNuNITsET(); } }
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
        
    }
    void oNuNITsET() {
        //StartCoroutine(WaitForSet());
        image.sprite = 
            Unit.UnitSprite;
    }
    IEnumerator WaitForSet() { 
    yield return null;
       
    }
}
