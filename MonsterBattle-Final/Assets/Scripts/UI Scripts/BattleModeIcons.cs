using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleModeIcons : MonoBehaviour
{
    public enum PowerUpType {AttackUp,DefenseUp,Bonus }
    [SerializeField] PowerUpType type;
    [SerializeField] int powerUp;
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    Button button;
    PlayerMon player;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        player = PlayerMon.GetPlayer();
        button = GetComponent<Button>();
        rbody = GetComponent<Rigidbody2D>();
        button.onClick.AddListener(AddPowerUp);
    }
    private void Update() {
        rbody.MovePosition(rbody.position +(direction*speed));
    }
    void AddPowerUp() {
        switch (type) {
            case PowerUpType.AttackUp:
                player.Unit.Attack *= powerUp;
                break;
            case PowerUpType.DefenseUp:
                player.Unit.Defense *= powerUp;
                break;
            case PowerUpType.Bonus:
                player.Unit.Attack *= powerUp;
                player.Unit.Defense *= powerUp;
                break;
        }
    }
}
