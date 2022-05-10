using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMn : MonoBehaviour
{
    private static EnemyMn instance;
    public static EnemyMn GetBoss() => instance;
    [SerializeField] private GameObject blast;
    Image image;
    public GameObject unitObj;
    private Boss unit;

    public Boss Unit { get => unit; set => unit = value; }

    private void Awake() {
        unit = unitObj.GetComponent<Boss>();

        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }
        unit.SetBoss();
    }
    // Start is called before the first frame update
    void Start() {

        //unit.Start();
        image = GetComponent<Image>();
        image.sprite = unitObj.GetComponent<Unit>().UnitSprite;
    }
    public void Attack() {
        Instantiate(blast, transform.position, Quaternion.identity);
    }
    //at the beginning of battle phase has to set when itll attack
    //random select number of attacks, then have a loop to get a random number for each number of attacks, then send to battle manager
    //numOfAttacks=RandomNum();
    //for(int i=0; i<numOfAttacks; i++)
    //store random numbers
    //send to Battle Manager
}
