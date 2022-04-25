using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public GameObject Attacker;
    public GameObject Defender;
    // Start is called before the first frame update
    void Start()
    {
        transform.LeanMoveLocal(Defender.transform.position,20).setEaseOutCubic();
    }
}
