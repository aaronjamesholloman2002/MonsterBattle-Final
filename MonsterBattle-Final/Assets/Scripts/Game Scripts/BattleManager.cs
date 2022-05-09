using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    PlayerMon player;
    EnemyMn boss;
    // Start is called before the first frame update
    void Start()
    {
        player = PlayerMon.GetPlayer();
        boss = EnemyMn.GetBoss();
    }
    void OnBattle() { //has to run like command phases
        //has to take in
    }
    public void Attack() {
        
        Debug.Log(player);
        boss.unit.Health -= player.Unit.Attack;
        Debug.Log(boss.unit.Health);
    }
}
