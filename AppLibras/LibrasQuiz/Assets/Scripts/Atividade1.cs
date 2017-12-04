using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade1 : MonoBehaviour {

	public GameObject[] imagens;
	public int index,total;
	public GameObject letraAtiva, botaoAtividade, btnRetroceder, popupcorreto, popupincorreto;
	private bool botaoAtivar;
	public AudioClip correto, errado;
	public AudioSource tocador;

	// Use this for initialization
	void Start () {
		//index = PlayerPrefs.GetInt ("letraSilaba");
		index = Random.Range(0,7);
		letraAtiva = imagens[index];
		letraAtiva.SetActive(true);


		//trocarImagens();
		//botaoAtivar = true;
	}

	// Update is called once per frame
	void Update () {
		/*if (index == imagens.Length - 1 && botaoAtivar == true) {
			Debug.Log ("ta pra apertar o botao");
			botaoAtividade.SetActive (true);
			botaoAtivar = false;
		} if(index != imagens.Length-1) {
			botaoAtividade.SetActive (false);
			botaoAtivar = true;
		}
		if (index == 0) {
			btnRetroceder.SetActive (false);
		} else {
			btnRetroceder.SetActive (true);
		}*/
	}

	public void trocarImagens()
	{
		//Handheld.Vibrate();
		tocador.PlayOneShot (correto);
		popupcorreto.SetActive (true);
		Invoke ("Change", 1);


	}

	public void percorrerIndex(int n){
		
		index+=n;
		trocarImagens();
	}

	void Change(){
		index = Random.Range(0,7);
		letraAtiva.SetActive(false);
		letraAtiva = imagens[index];
		letraAtiva.SetActive(true);
		popupcorreto.SetActive (false);
		popupincorreto.SetActive (false);
	
	}

	public void Incorreto(){
		Handheld.Vibrate();
		popupincorreto.SetActive (true);
		tocador.PlayOneShot (errado);
		Invoke ("Change", 1);
	}

}
