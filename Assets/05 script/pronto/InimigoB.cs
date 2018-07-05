using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoB : MonoBehaviour {

    public int dano;
    public GameObject explosaoGo;
    private ControllerB controller;

    private void Awake () {

        controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ControllerB> ();
    }



    private void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag ("TiroPlayer")) {

            Explodir ();
        }

        if (collision.CompareTag ("Player")) {
           
            controller.MudarVida (dano);           
        }
            
        
    }

    void Explodir () {

        GameObject obj = Instantiate (explosaoGo,this.gameObject.transform.position,Quaternion.identity);
       
        Destroy (this.gameObject,0.0f);
        
        
    }

}
