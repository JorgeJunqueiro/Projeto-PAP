using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarMenuPrincipal : MonoBehaviour {

	public void Voltar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	public void Nivel1(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void Nivel2(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
	}

	public void Nivel3(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 3);
	}

	public void Nivel4(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 4);
	}

	public void CampoTiro(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 5);
	}
}
