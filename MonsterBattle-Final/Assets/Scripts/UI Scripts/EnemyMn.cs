using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMn : MonoBehaviour
{
    private static EnemyMn instance;
    public static EnemyMn GetBoss() => instance;

    Image image;
    public Unit unit;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        image=GetComponent<Image>();
        image.sprite = unit.UnitSprite;
    }

    //at the beginning of battle phase has to set when itll attack
    //random select number of attacks, then have a loop to get a random number for each number of attacks, then send to battle manager
    //numOfAttacks=RandomNum();
    //for(int i=0; i<numOfAttacks; i++)
    //store random numbers
    //send to Battle Manager
}
