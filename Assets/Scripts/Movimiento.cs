using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	public Vector3 velocidad = new Vector3(0.03f, 0.0f,0.0f);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		GameObject player = GameObject.Find ("Player");
		Vector3 move = player.GetComponent<CharacterController> ().SimpleMove(velocidad);
		player.transform.position = move * Time.deltaTime;

	}
}
