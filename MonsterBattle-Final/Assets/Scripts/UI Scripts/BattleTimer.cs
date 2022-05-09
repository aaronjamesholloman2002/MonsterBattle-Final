using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleTimer : MonoBehaviour
{
    Text text;
    int time;
    Coroutine timer;
    // Start is called before the first frame update
    void Start() {
        text = GetComponent<Text>();
        BattleManager.resetTimer += SetTime;
    }
    void SetTime() {
        time = 21;
        text.text = "Battle Timer: " + time.ToString();
        if (time > 0) {
            timer = StartCoroutine(TickTimer());
        }
        else
            StopCoroutine(timer);
    }
    IEnumerator TickTimer() {
        YieldInstruction wait = new WaitForSeconds(1);
        while (isActiveAndEnabled) {
            yield return wait;

            time--;
            text.text = "Battle Timer: " + time.ToString();

        }
    }
}
