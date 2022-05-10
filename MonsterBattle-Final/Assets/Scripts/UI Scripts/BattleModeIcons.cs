using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class BattleModeIcons : MonoBehaviour
{
    public static event UnityAction statsUp;
    public enum PowerUpType { AttackUp, DefenseUp, HealthUp, Bonus }
    [SerializeField] PowerUpType type;
    [SerializeField] int powerUp;
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    [SerializeField] GameObject effect;
    Button button;
    PlayerMon player;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    public void Start() {
        print("SPawned");
        player = PlayerMon.GetPlayer();
        button = GetComponent<Button>();
        rbody = GetComponent<Rigidbody2D>();
        //button.onClick.AddListener(AddPowerUp);
    }
    private void Update() {
        rbody.MovePosition(rbody.position + (direction * speed));
    }
    public void AddPowerUp() {
        print("Clicked");
        switch (type) {
            case PowerUpType.AttackUp:
                player.Unit.Attack += powerUp;
                break;
            case PowerUpType.DefenseUp:
                player.Unit.Defense += powerUp;
                break;
            case PowerUpType.HealthUp:
                if (player.Unit.Health < 100) { 
                player.Unit.Health += powerUp;
                }
                break;
            case PowerUpType.Bonus:
                player.Unit.Attack += powerUp;
                player.Unit.Defense += powerUp;
                break;
        }
        statsUp.Invoke();
        //Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
