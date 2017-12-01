using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PassaCena (string cena){
		SceneManager.LoadScene (cena);
	}

	public void FaseParametro(int faseLetraSilaba){
		PlayerPrefs.SetInt("letraSilaba", faseLetraSilaba);
		//SceneManager.LoadScene (PlayerPrefs.GetInt ("letraSilaba"));
	}
}
