using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {

            Debug.Log("Object entered");
            Destroy(collision.gameObject);

    }
}
