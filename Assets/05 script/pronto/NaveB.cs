using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveB : MonoBehaviour {

    public GameObject naveGo;
    public GameObject fireGo;
    public GameObject canhaoGo;
    public GameObject explosaoGo;
    public float cadencia;

    [Range(2,10)]
    public float velocidade;

    private float ultimoTiro;
 
   
	
	void Update () {

        if (Input.GetKey (KeyCode.Space))  {

            Atirar ();
        }

        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
		

	}

    void FixedUpdate () {


        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");


        if (vertical != 0 || horizontal != 0) {

         
            naveGo.transform.Translate (new Vector3 (-vertical * velocidade / 40,horizontal * velocidade / 40));

           

           
        }
       


    }

    void Atirar () {

        if (Time.time > cadencia + ultimoTiro) {


            GameObject obj = Instantiate (fireGo,canhaoGo.transform.position,Quaternion.identity);

            ultimoTiro = Time.time;
        }

    }

    public void Explodir () {

        GameObject obj = Instantiate (explosaoGo,naveGo.transform.position,Quaternion.identity);

        Destroy (this.gameObject,0.0f);


       
    }

   
}
