using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyGirl : MonoBehaviour {
	public GameObject confirmaBTN, menina, menino, menino1, menina1;
	public AudioClip somBotao;
	public AudioSource tocador;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BoyorGirl(int sexo){
		tocador.PlayOneShot (somBotao);
		//Handheld.Vibrate();
		if (sexo == 1) {
			menino.SetActive (true);
			menino1.SetActive (false);
			menina1.SetActive (true);
			menina.SetActive (false);
		} else {
			menina.SetActive (true);
			menina1.SetActive (false);
			menino1.SetActive (true);
			menino.SetActive (false);
		}
		PlayerPrefs.SetInt ("sexoJogador", sexo);
		confirmaBTN.SetActive (true);
	}


}
