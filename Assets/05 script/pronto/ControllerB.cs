using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerB : MonoBehaviour {


    public Slider barra;
    public GameObject gameOverTelaGo;
    private NaveB naveSpt;
    private int vida = 5;



    private void Awake () {

        naveSpt = GameObject.FindGameObjectWithTag ("Nave").GetComponent<NaveB> ();

    }

    void Start () {

        barra.maxValue = 5;
        barra.value = 5;
        
		
	}
	

    public void MudarVida(int valor) {

        Debug.Log ("Dano");
        if (vida + valor > 0) {

            vida += valor;
            
        }

        else {
            //Game Over
            vida = 0;
            naveSpt.Explodir ();
            Invoke ("AdicionarTelaGameOver",0.75f);
            Invoke ("Reiniciar", 2.5f);
        }

        barra.value = vida;

    }

    private void AdicionarTelaGameOver () {

        gameOverTelaGo.SetActive (true);

    }

    private void Reiniciar () {

        SceneManager.LoadScene (0);

    }
}
