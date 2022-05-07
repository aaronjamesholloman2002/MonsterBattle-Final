using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectorCanvas : MonoBehaviour
{
    [SerializeField]Image image;
    // Start is called before the first frame update
    void Start()
    {
        UnitSelecter.currentUpdated += SetImage;

    }
    private void SetImage(Unit unit) {
        image.sprite = unit.UnitSprite;
    }
}
