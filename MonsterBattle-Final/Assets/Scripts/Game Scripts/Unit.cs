using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public enum Types { Blue, Red, Green, Purple }
    [SerializeField] Types type;
    [SerializeField] private int health;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int speed;
    private int att;
    private int def;
    private int sped;
    private int heal;
    [SerializeField] private Sprite unitSprite;
    public int Health { get => heal; set { Debug.Log(value); heal = value; } }
    public Sprite UnitSprite { get => unitSprite; set => unitSprite = value; }
    public int Attack { get => att; set { Debug.Log(value); att = value; } }
    public int Defense { get => def; set { def = value; Debug.Log(value); } }
    public int Speed { get => sped; set { sped = value; Debug.Log(value); } }
    public void SetStats() {
        att = attack;
        def = defense;
        sped = speed;
        heal = health;
        print(health);
    }

}
