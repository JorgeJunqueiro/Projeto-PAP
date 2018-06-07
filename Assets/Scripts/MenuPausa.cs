using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour {

	public static bool Pausa = false;
	public GameObject MenuPausaUI;


	void Start()
	{
		UnityEngine.Cursor.visible = false;
	}

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (Pausa) {
				Resumir ();
			} else {
				Pausar ();			
			}

		}
	}

	public void Resumir()
	{
		MenuPausaUI.SetActive (false);
		Time.timeScale = 1f;
		Pausa = false;
		UnityEngine.Cursor.visible = false;
	}

	void Pausar()
	{
		MenuPausaUI.SetActive (true);
		Time.timeScale = 0f;
		Pausa = true;
		UnityEngine.Cursor.visible = true;
	}

	public void MenuPrincipal()
	{
		Debug.Log ("A carregar Menu...");
		SceneManager.LoadScene("Menu");
	}

	public void Sair()
	{
		Debug.Log ("A Sair do Jogo...");
		Application.Quit();
	}
}
