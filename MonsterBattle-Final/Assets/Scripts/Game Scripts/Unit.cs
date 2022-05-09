using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unit :MonoBehaviour
{
    public enum Types {Blue,Red,Green,Purple }
    [SerializeField] Types type;
    [SerializeField] public int health;
    [SerializeField] public int attack;
    [SerializeField] public int defense;
    [SerializeField] public int speed;
    private int att;
    private int def;
    private int sped;
    [SerializeField] public Sprite unitSprite;
    public int Health { get => health; set { Debug.Log(value); health = value; } }
    public Sprite UnitSprite { get => unitSprite; set => unitSprite = value; }
    public int Attack { get => att; set { Debug.Log(value); att = value; } }
    public int Defense { get => def; set { def = value; Debug.Log(value); } }
    public int Speed { get => sped; set { sped = value; Debug.Log(value); } }
    public void Start() {
        att = attack;
        def = defense;
        sped = speed;
    }
}
