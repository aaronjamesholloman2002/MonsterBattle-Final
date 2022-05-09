using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Blast : MonoBehaviour
{
    public static event UnityAction playerdmg;
    public static event UnityAction enemydmg;
    [SerializeField]bool player;
    [SerializeField]GameObject splash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player) {
            Vector2.MoveTowards(transform.position, EnemyMn.GetBoss().gameObject.transform.position, 15f);
        }
        else {
            Vector2.MoveTowards(transform.position, PlayerMon.GetPlayer().gameObject.transform.position, 15f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (player && collision.GetComponent<EnemyMn>()) {
            Instantiate(splash, collision.transform.position, Quaternion.identity);
            enemydmg.Invoke();
        }
        else if (collision.GetComponent<PlayerMon>()) {
            Instantiate(splash, collision.transform.position, Quaternion.identity);
            playerdmg.Invoke();
        }
    }
}
