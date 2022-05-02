using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public GameObject Defender;
    public float delay = 0f;
    private float defPos = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        defPos = Defender.GetComponent<RectTransform>().anchoredPosition.x;

        LeanTween.moveX(gameObject.GetComponent<RectTransform>(), defPos, 0.3f).setDelay(delay).setOnComplete(Explode);
    }

    void Explode()
    {
        LeanTween.scale(gameObject, new Vector3(10,10,10), 0.2f).setOnComplete(DestroyMe);
        LeanTween.rotate(gameObject, new Vector3(0, 0, 180), 0.2f).setOnComplete(DestroyMe);
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, 0.2f).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
