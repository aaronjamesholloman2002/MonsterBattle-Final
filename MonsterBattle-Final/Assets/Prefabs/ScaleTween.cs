using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public GameObject Defender;
    public float delay = 0f;
    private float defPos = 0f;
    public bool isPlayerAttacker = true;

    // Start is called before the first frame update
    void OnEnable()
    {
        /*defPos = Defender.GetComponent<RectTransform>().anchoredPosition.x;
        if (isPlayerAttacker == true)
        {
            gameObject.GetComponent<ScaleTween>().Defender = enemy;
        }
        else
        {
            gameObject.GetComponent<ScaleTween>().Defender = player;
        }*/

        Move();
    }

    void Move()
    {
        LeanTween.moveX(gameObject.GetComponent<RectTransform>(), defPos, 0.3f).setDelay(delay).setOnComplete(Explode);
    }

    void Explode()
    {
        LeanTween.scale(gameObject, new Vector3(10,10,10), 0.2f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, 180), 0.2f);
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, 0.2f).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
