
using UnityEngine;

public class ScriptArma : MonoBehaviour {

	public float dano = 10f;
	public float alcance = 100f;
	public float ForcaImpacto =30f;

	public Camera fpsCam;
	public ParticleSystem FlashCan;
	public GameObject EfeitoImpacto;

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Disparo ();			
		}

	}

	void Disparo()
	{
		FlashCan.Play ();

		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, alcance)) 
		{
			Debug.Log (hit.transform.name);

			Alvo alvo = hit.transform.GetComponent<Alvo> ();
			if (alvo != null) 
			{
				alvo.levaDano (dano);
			}

			if (hit.rigidbody != null) 
			{
				hit.rigidbody.AddForce (-hit.normal * ForcaImpacto);
			}

			GameObject ImpactoGO = Instantiate(EfeitoImpacto, hit.point, Quaternion.LookRotation(hit.normal));
			Destroy (ImpactoGO, 1f);
		}
	}
}
