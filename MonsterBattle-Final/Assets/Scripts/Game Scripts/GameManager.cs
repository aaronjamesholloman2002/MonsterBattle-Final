using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //[Header("Monsters")]
    public PlayerMon player;
    //public GameObject Enemy;
    //[Header("UI")]
    //public GameObject PlayerHP;
    //public GameObject EnemyHP;
    //public GameObject Buttons;
    //public GameObject Dialogue;
    //[Header("Attacks")]
    //public GameObject Bullet;
    Unit playerUnit;
    // Start is called before the first frame update
    private void OnEnable() {
        SceneManager.sceneLoaded += OnFinshiedLoading;
    }

    private void OnDisable() {
        SceneManager.sceneLoaded -= OnFinshiedLoading;
    }
    void Start()
    {
        UnitSelecter.selected += SetUnit;
        DontDestroyOnLoad(this);
    }

    private void SetUnit(Unit unit) {
        playerUnit = unit;
    }
    void OnFinshiedLoading(Scene scene,LoadSceneMode mode) {
        if (scene.buildIndex == 2) {
            player = PlayerMon.GetPlayer();
            player.Unit = playerUnit;
        }
    }
}
