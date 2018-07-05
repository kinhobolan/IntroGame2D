using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoB : MonoBehaviour {

    // Use this for initialization



    void Start () {


        Invoke ("PararDeAcelerar",0.75f);

    }

    void PararDeAcelerar () {

        this.gameObject.GetComponent<ConstantForce2D> ().enabled = false;

        // Destroy (this.gameObject.GetComponent<ConstantForce2D>());
    }
}
