using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {


	public float Volocidade = 6.0f;
	public float gravidade = -9.8f;


	private CharacterController _charCont;
	// Use this for initialization
	void Start () {
		_charCont = GetComponent<CharacterController> ();		
	}
	
	// Update is called once per frame
	void Update () {
		float deltaX = Input.GetAxis ("Horizontal") * Volocidade;
		float deltaZ = Input.GetAxis ("Vertical") * Volocidade;
		Vector3 movement = new Vector3 (deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude (movement, Volocidade);

		movement.y = gravidade;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		_charCont.Move (movement);

	}
}
