using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Unit
{
    [SerializeField] int bossLevel;
    // Start is called before the first frame update
    void Start()
    {
        Health *= bossLevel;
        Attack *= bossLevel;
        Defense *= bossLevel;
    }

}
