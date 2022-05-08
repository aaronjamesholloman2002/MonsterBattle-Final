using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Accessbar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetComponent<BattleModeIcons>()) {
            //Debug.Log("access bar entered");
            collision.GetComponent<Button>().interactable = true;
        }
    }
}
