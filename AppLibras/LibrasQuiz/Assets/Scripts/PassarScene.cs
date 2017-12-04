using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarScene : MonoBehaviour {
	public AudioClip somBotao;
	public AudioSource tocador;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PassaCena (string cena){
		tocador.PlayOneShot (somBotao);
		SceneManager.LoadScene (cena);
		//Handheld.Vibrate();
	}

	public void FaseParametro(int faseLetraSilaba){
		PlayerPrefs.SetInt("letraSilaba", faseLetraSilaba);
		//SceneManager.LoadScene (PlayerPrefs.GetInt ("letraSilaba"));
	}
}
