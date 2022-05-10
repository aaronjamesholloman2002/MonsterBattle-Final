using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleTimer : MonoBehaviour
{
    Text text;
    public int time = 21;
    Coroutine timer;
    // Start is called before the first frame update
    void Start() {
        text = GetComponent<Text>();
        BattleManager.resetTimer += SetTime;
    }
    void SetTime() {
        //time = 21;
        text.text = "Battle Timer: " + time.ToString();
        if (time > 0) {
            timer = StartCoroutine(TickTimer());
        }
        else
            StopCoroutine(timer);
    }
    IEnumerator TickTimer() {
		int countTime = time;
        YieldInstruction wait = new WaitForSeconds(1);
        while (isActiveAndEnabled) {
            yield return wait;

            countTime--;
            text.text = "Battle Timer: " + countTime.ToString();
        }
		countTime = time;
    }
}
