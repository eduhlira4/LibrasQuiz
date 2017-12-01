using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBotoes : MonoBehaviour {

    public GameObject[] imagens;
	public int index;
	public GameObject letraAtiva, botaoAtividade, btnRetroceder;
	private bool botaoAtivar;

	// Use this for initialization
	void Start () {
		//index = PlayerPrefs.GetInt ("letraSilaba");
		letraAtiva = imagens[index];
		trocarImagens();
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
		letraAtiva.SetActive(false);
		letraAtiva = imagens[index%26];
		letraAtiva.SetActive(true);
    }

	public void percorrerIndex(int n){
		index+=n;
		trocarImagens();
	}
		
}
