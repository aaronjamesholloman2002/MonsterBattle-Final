using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIconSpawner : MonoBehaviour
{
	
    private Coroutine spawn;
    [SerializeField] GameObject[] icons;
    // Start is called before the first frame update
    private void OnEnable() {
        spawn = StartCoroutine(WaitToSpawn());
    }
    private void OnDisable() {
        StopCoroutine(spawn);
    }
    void Start() {
        
    }
    IEnumerator WaitToSpawn() {
		
        YieldInstruction wait = new WaitForSeconds(0.4f);
        while (isActiveAndEnabled) {
            yield return wait;
            SpawnIcon();
        }
    }
	
    void SpawnIcon() {
        int rand = Random.Range(0, 3);
		int hors = Random.Range(-400, 400);
        GameObject bubble = Instantiate(icons[rand], transform);
		LeanTween.moveX(bubble.GetComponent<RectTransform>(), hors, 0.0f);
	}
}
