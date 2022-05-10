using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BattleManager : MonoBehaviour
{
    PlayerMon player;
    EnemyMn boss;

    [SerializeField] private GameObject gatherMode;
    [SerializeField] private GameObject timer;

    bool playerAttacked;
    bool enemyAttacked;
    public static UnityAction resetTimer;
    public static event UnityAction playerdmg;
    public static event UnityAction enemydmg;
    public static event UnityAction newPhase;
    public static event UnityAction updateEnemyStats;
    // Start is called before the first frame update
    void Start() {
        player = PlayerMon.GetPlayer();
        boss = EnemyMn.GetBoss();
        Blast.playerdmg += PlayerDamage;
        Blast.enemydmg += EnemyDamage;
        //Send begin text
        StartCoroutine(waitTilGatherPhase());
    }
    void OnBattle() { //has to run like command phases
                      //has to take in

    }
    //Activate gather mode
    void GatherMode() {
        if (updateEnemyStats != null) {
            updateEnemyStats.Invoke();
        }

        newPhase.Invoke();
        playerAttacked = false;
        enemyAttacked = false;
        gatherMode.SetActive(true);
        timer.SetActive(true);
        resetTimer.Invoke();
        StartCoroutine(waitTilBattlePhase());
    }
    //Switch to attack phase
    void AttackPhase() {
        print("Start Attack phase");
        gatherMode.SetActive(false);
        timer.SetActive(false);
        if (player.Unit.Speed > boss.Unit.Speed) {
            StartCoroutine(playerAttack(3));
            StartCoroutine(enemyAttack(8));
        }
        else {
            StartCoroutine(enemyAttack(3));
            StartCoroutine(playerAttack(8));
        }
        //Repeat();
    }
    //determine whether to repeat or switch to win state or
    //lose
    void Repeat() {
        if (player.Unit.Health <= 0) {
            GameManager.LoadScene(4);
        }
        else if (boss.Unit.Health <= 0) {
            GameManager.LoadScene(3);
        }
        else {
            GatherMode();

            //Enemy gets stronger send event
        }
    }
    void EnemyDamage() {
        boss.Unit.Health -= Mathf.Clamp(player.Unit.Attack - boss.Unit.Defense, 1, 999999);
        enemydmg.Invoke();
    }
    void PlayerDamage() {
        player.Unit.Health -= Mathf.Clamp(boss.Unit.Attack - player.Unit.Defense, 1, 999999);
        playerdmg.Invoke();
    }
    public void Attack() {

        Debug.Log(player);
        boss.Unit.Health -= player.Unit.Attack;
        Debug.Log(boss.Unit.Health);
    }
    void RepeatCheck() {
        if (enemyAttacked && playerAttacked) {
            Repeat();
        }
    }
    IEnumerator waitTilBattlePhase() {
        YieldInstruction wait = new WaitForSeconds(20);
        yield return wait;
        AttackPhase();
    }
    IEnumerator waitTilGatherPhase() {
        YieldInstruction wait = new WaitForSeconds(0.5f);
        yield return wait;
        GatherMode();
    }
    IEnumerator playerAttack(int time) {
        YieldInstruction wait = new WaitForSeconds(time);
        yield return wait;
        print("Player Attacks");
        playerAttacked = true;
        if (player.Unit.Health > 0) {
            //player.Attack();
            EnemyDamage();
        }
        RepeatCheck();
    }
    IEnumerator enemyAttack(int time) {
        YieldInstruction wait = new WaitForSeconds(time);
        yield return wait;
        print("Enemy Attacks");
        enemyAttacked = true;
        if (boss.Unit.Health > 0) {
            //boss.Attack();
            PlayerDamage();
        }
        RepeatCheck();
    }
}
