using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unit :MonoBehaviour
{
    private int health;
    [SerializeField] private Sprite unitSprite;
    public int Health { get => health; set => health = value; }
    public Sprite UnitSprite { get => unitSprite; set => unitSprite = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
