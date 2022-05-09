using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public GameObject Defender;
    public float delay = 0f;
    private float defPos = 500f;
    public bool isPlayerAttacker = true;
	
    void OnEnable()
    {
        Move();
    }

    void Move()
    {
		transform.SetSiblingIndex(0);
		isPlayerAttacker = true;
		if (isPlayerAttacker)
		{
			LeanTween.moveX(gameObject.GetComponent<RectTransform>(), 300f, 0.0f);
			LeanTween.moveX(gameObject.GetComponent<RectTransform>(), defPos, 0.3f).setDelay(delay).setOnComplete(Explode);
		}
		else
		{
			LeanTween.moveX(gameObject.GetComponent<RectTransform>(), 500f, 0.0f);
			LeanTween.moveX(gameObject.GetComponent<RectTransform>(), 300f, 0.3f).setDelay(delay).setOnComplete(Explode);
		}
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
