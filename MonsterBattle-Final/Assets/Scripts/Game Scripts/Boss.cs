using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Unit
{
    [SerializeField] int growthRate;
    // Start is called before the first frame update
    public void SetBoss() {
        SetStats();
        BattleManager.updateEnemyStats += GrowStronger;
        Health *= 3;
    }
    private void GrowStronger() {
        Attack *= growthRate;
        Defense *= growthRate;
        Speed *= growthRate;
    }

}
