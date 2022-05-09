using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unit :MonoBehaviour
{
    public enum Types {Blue,Red,Green,Purple }
    [SerializeField] Types type;
    [SerializeField]private int health;
    [SerializeField]private int attack;
    [SerializeField]private int defense;

    [SerializeField] private Sprite unitSprite;
    public int Health { get => health; set => health = value; }
    public Sprite UnitSprite { get => unitSprite; set => unitSprite = value; }
    public int Attack { get => attack; set => attack = value; }
    public int Defense { get => defense; set => defense = value; }


    
}
