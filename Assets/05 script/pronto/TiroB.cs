using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroB : MonoBehaviour {

    // Use this for initialization
    void Start () {

        Destroy (this.gameObject,1.1f);
    }

    private void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag ("Inimigo")) {

            Destroy (this.gameObject);
        }
    }
}

    
