using UnityEngine;

public class Alvo : MonoBehaviour {

	public float vida = 50f;

	public void levaDano (float quantidade)
	{
		vida -= quantidade;
		if (vida <= 0f) 
		{
			Morre ();
		}
	}

	void Morre()
	{
		Destroy (gameObject);
	}
}
