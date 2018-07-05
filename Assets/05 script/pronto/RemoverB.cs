using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverB : MonoBehaviour {

    public float tempo;

	void Start () {

        Destroy (this.gameObject,tempo);
	}
	
	
}
